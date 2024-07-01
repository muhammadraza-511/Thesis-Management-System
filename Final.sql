
CREATE TABLE UserRole (
    RoleID INT PRIMARY KEY,
	--UserName VARCHAR(255),
    RoleName VARCHAR(255),
    Password VARCHAR(255)
);
 
--ALTER TABLE UserRole
--ADD UserName1 VARCHAR(255);


CREATE TABLE Supervisor (
    SupervisorID INT PRIMARY KEY,
    Name VARCHAR(255),
    Email VARCHAR(255),
    DOB DATE,
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES UserRole(RoleID)
);

--drop table Student

 CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    SName VARCHAR(255),
    Email VARCHAR(255),
    DOB DATE,
    Phone VARCHAR(20),
    RoleID INT,
    SupervisorID INT,
    FOREIGN KEY (RoleID) REFERENCES UserRole(RoleID),
    FOREIGN KEY (SupervisorID) REFERENCES Supervisor(SupervisorID)
);

CREATE TABLE ThesisProposal (
    ProposalID INT PRIMARY KEY,
    Title VARCHAR(255),
    Description TEXT,
    Status VARCHAR(50),
    SubmissionDate DATE,
    --ApprovalDate DATE,
    StudentID INT,
    SupervisorID INT,
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (SupervisorID) REFERENCES Supervisor(SupervisorID)
);

ALTER TABLE ThesisProposal
DROP COLUMN ApprovalDate;



CREATE TABLE PanelMember (
    PanelMemberID INT PRIMARY KEY,
    PM_Name VARCHAR(255),
    Email VARCHAR(255),
    DOB DATE,
    ProposalID INT,
    RoleID INT,
    FOREIGN KEY (ProposalID) REFERENCES ThesisProposal(ProposalID),
    FOREIGN KEY (RoleID) REFERENCES UserRole(RoleID)
);


CREATE TABLE Review (
    ReviewID INT PRIMARY KEY,
    Comments TEXT,
    Remarks VARCHAR(255),
    ProposalID INT,
    PanelMemberID INT,
    FOREIGN KEY (ProposalID) REFERENCES ThesisProposal(ProposalID),
    FOREIGN KEY (PanelMemberID) REFERENCES PanelMember(PanelMemberID)
);

CREATE TABLE Administrator (
    AdminID INT PRIMARY KEY,
    AName VARCHAR(255),
    Email VARCHAR(255),
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES UserRole(RoleID)
);


CREATE TABLE Notification (
    NotificationID INT PRIMARY KEY,
    Content TEXT,
    Recipient VARCHAR(255),
    Timestamp DATETIME,
    Status VARCHAR(50)
);

ALTER TABLE Notification
DROP COLUMN Status;

CREATE TABLE ReviewsConduct (
    ThesisID INT,
    PanelMemberID INT,
    ReviewID INT,
    PRIMARY KEY (ThesisID, PanelMemberID, ReviewID),
    FOREIGN KEY (ThesisID) REFERENCES ThesisProposal(ProposalID),
    FOREIGN KEY (PanelMemberID) REFERENCES PanelMember(PanelMemberID),
    FOREIGN KEY (ReviewID) REFERENCES Review(ReviewID)
);


INSERT INTO UserRole (RoleID, RoleName, Password, Username1)
VALUES ('1', 'Admin', 'Munam123', 'Munam');

INSERT INTO ThesisProposal (ProposalID, Title, Description, Status, SubmissionDate, ApprovalDate, StudentID, SupervisorID) VALUES 
(1, 'Sample Thesis 1', 'Description for Sample Thesis 1.', 'Pending', '2023-11-24', NULL, 456, 9);



select * from UserRole
select * from Supervisor
select * from Student
select * from ThesisProposal
select * from PanelMember
select * from Administrator
select * from Review
select * from Notification
select * from ReviewsConduct






-- Password validation trigger

GO -- Use GO to separate batches

CREATE TRIGGER PasswordLengthCheck
ON UserRole
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE LEN(Password) < 7
    )
    BEGIN
        THROW 50000, 'Password must be 7 characters or longer.', 1;
        ROLLBACK;
    END
END;







   -- This trigger ensures that a student can have at most one supervisor.

go

CREATE TRIGGER tr_Student_SingleSupervisor
   ON Student
   INSTEAD OF INSERT, UPDATE
   AS
   BEGIN
       IF (SELECT COUNT(*) FROM inserted WHERE SupervisorID IS NOT NULL) > 1
       BEGIN
           THROW 50000, 'A student cannot have more than one supervisor.', 1;
           ROLLBACK;
       END;
       ELSE
       BEGIN
           INSERT INTO Student (StudentID, SName, Email, DOB, Phone, RoleID, SupervisorID)
           SELECT StudentID, SName, Email, DOB, Phone, RoleID, SupervisorID FROM inserted;
       END;
   END;


   
   ---------------------------------------triggers with nested subqueries-------------------------------



   --   This trigger ensures that when a UserRole is deleted, related records in other tables are also deleted.
go
   CREATE TRIGGER tr_UserRole_CascadeDelete
   ON UserRole
   INSTEAD OF DELETE
   AS
   BEGIN
       DELETE FROM ThesisProposal WHERE StudentID IN (SELECT StudentID FROM deleted);
       DELETE FROM Student WHERE RoleID IN (SELECT RoleID FROM deleted);
       DELETE FROM Supervisor WHERE RoleID IN (SELECT RoleID FROM deleted);
       DELETE FROM UserRole WHERE RoleID IN (SELECT RoleID FROM deleted);
   END;




   --This trigger uses a nested subquery to check if all reviews for a 
   --proposal are approved and updates the proposal status accordingly.
   go
   CREATE TRIGGER UpdateProposalStatusOnReviewSubmission
ON Review
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE tp
    SET tp.Status = 
        CASE 
            WHEN NOT EXISTS (
                SELECT 1
                FROM Review r
                WHERE r.ProposalID = tp.ProposalID AND r.Remarks <> 'Approved'
            ) THEN 'Approved'
            ELSE 'Under Review'
        END
    FROM ThesisProposal tp
    WHERE tp.ProposalID IN (SELECT ProposalID FROM inserted);
END;


--This trigger uses a nested subquery to check if a panel member has reached the 
--maximum allowed reviews and prevents further assignments.
go
CREATE TRIGGER CheckReviewCountLimit
ON Review
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF (SELECT COUNT(*)
        FROM Review r
        WHERE r.PanelMemberID IN (SELECT PanelMemberID FROM inserted)
    ) > 10
    BEGIN
        THROW 50000, 'Panel member has reached the maximum review limit.', 1;
    END
    ELSE
    BEGIN
        INSERT INTO Review (Comments, Remarks, ProposalID, PanelMemberID)
        SELECT Comments, Remarks, ProposalID, PanelMemberID
        FROM inserted;
    END
END;

--This trigger uses a nested subquery to check if a student is eligible
--to submit a proposal based on their previous submissions.
go
CREATE TRIGGER CheckStudentEligibilityOnProposalSubmission
ON ThesisProposal
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM ThesisProposal tp
        WHERE tp.StudentID IN (SELECT StudentID FROM inserted)
          AND tp.Status = 'Approved'
    )
    BEGIN
        THROW 50000, 'Student is not eligible to submit a new proposal.', 1;
    END
END;







---------------------Nested + 2 tables join-------------------------
--trigger that ensures a student cannot be assigned to a supervisor who already has a maximum number of students

go
CREATE TRIGGER CheckSupervisorStudentLimit
ON Student
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaxStudents INT;
    SET @MaxStudents = 5; 

    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN Supervisor s ON i.SupervisorID = s.SupervisorID
        WHERE (SELECT COUNT(*) FROM Student WHERE SupervisorID = i.SupervisorID) >= @MaxStudents
    )
    BEGIN
        THROW 50000, 'Supervisor has reached the maximum allowed students.', 1;
    END
END;


--When a supervisor is changed for a student, this trigger updates 
--the student's information in the Student table.
go
CREATE TRIGGER UpdateStudentOnSupervisorChange
ON Supervisor
AFTER UPDATE
AS
BEGIN
    UPDATE s
    SET s.SupervisorID = i.SupervisorID
    FROM Student s
    INNER JOIN inserted i ON s.SupervisorID = i.SupervisorID;
END;


--When the status of a proposal is changed, this trigger updates the review comments in the Review table.

go
CREATE TRIGGER UpdateReviewCommentsOnProposalStatusChange
ON ThesisProposal
AFTER UPDATE
AS
BEGIN
    UPDATE r
    SET r.Comments = 'Proposal Status Updated to: ' + i.Status
    FROM Review r
    INNER JOIN inserted i ON r.ProposalID = i.ProposalID;
END;


--Notify the supervisor when a proposal is approved.
go
CREATE TRIGGER NotifySupervisorOnApproval
ON ThesisProposal
AFTER UPDATE
AS
BEGIN
    DECLARE @Content NVARCHAR(255) = 'Your student''s proposal has been approved.';
    
    INSERT INTO Notification (Content, Recipient, Timestamp)
    SELECT @Content, s.Email, GETDATE()
    FROM Supervisor s
    INNER JOIN inserted i ON s.SupervisorID = i.SupervisorID
    WHERE i.Status = 'Approved';
END;



------------------------------------3 tables join
go

