SET NOCOUNT ON
GO

USE master
GO
if exists (select * from sysdatabases where name='QuizSystemDB')
		drop database QuizSystemDB
go

DECLARE @device_directory NVARCHAR(520)
SELECT @device_directory = SUBSTRING(filename, 1, CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1

EXECUTE (N'CREATE DATABASE QuizSystemDB
  ON PRIMARY (NAME = N''QuizSystemDB'', FILENAME = N''' + @device_directory + N'quizsystemdb.mdf'')
  LOG ON (NAME = N''QuizSystemDB_log'',  FILENAME = N''' + @device_directory + N'quizsystemdb.ldf'')')
go

GO

set quoted_identifier on
GO

SET DATEFORMAT mdy
GO
use "QuizSystemDB"
go
CREATE TABLE [Student] (
	id integer IDENTITY(1,1)  NOT NULL,
	name nvarchar(35) NOT NULL,
	surname nvarchar(35) NOT NULL,
	email nvarchar(150) NOT NULL UNIQUE,
	password nvarchar(150) NOT NULL,
  CONSTRAINT [PK_STUDENT] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Teacher] (
	id integer IDENTITY(1,1)  NOT NULL,
	name nvarchar(35) NOT NULL,
	surname nvarchar(35) NOT NULL,
	email nvarchar(150) NOT NULL UNIQUE,
	password nvarchar(150) NOT NULL,
  CONSTRAINT [PK_TEACHER] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Admin] (
	id integer IDENTITY(1,1)  NOT NULL,
	email nvarchar(150) NOT NULL UNIQUE,
	password nvarchar(150) NOT NULL,
  CONSTRAINT [PK_ADMIN] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Exam] (
	id integer IDENTITY(1,1)  NOT NULL,
	title nvarchar(155) NOT NULL,
  CONSTRAINT [PK_EXAM] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Question] (
	id integer IDENTITY(1,1)  NOT NULL,
	Text ntext NOT NULL,
	correctVariant nvarchar(1) NOT NULL,
	ExamID integer NOT NULL,
  CONSTRAINT [PK_QUESTION] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Variant] (
	id integer IDENTITY(1,1)  NOT NULL,
	variantType nvarchar(1) NOT NULL,
	variantText ntext NOT NULL,
	questionId integer NOT NULL,
  CONSTRAINT [PK_VARIANT] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [TakeExam] (
	id integer IDENTITY(1,1)  NOT NULL,
	student_id integer  NOT NULL,
	exam_id integer NOT NULL,
	date datetime NOT NULL,
	amountCorrectAnswer integer NOT NULL,
	amountWrongAnswer integer NOT NULL,
  CONSTRAINT [PK_TAKEEXAM] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO




ALTER TABLE [Question] WITH CHECK ADD CONSTRAINT [Question_fk0] FOREIGN KEY ([ExamID]) REFERENCES [Exam]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Question] CHECK CONSTRAINT [Question_fk0]
GO

ALTER TABLE [Variant] WITH CHECK ADD CONSTRAINT [Variant_fk0] FOREIGN KEY ([questionId]) REFERENCES [Question]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Variant] CHECK CONSTRAINT [Variant_fk0]
GO

ALTER TABLE [TakeExam] WITH CHECK ADD CONSTRAINT [TakeExam_fk0] FOREIGN KEY ([student_id]) REFERENCES [Student]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [TakeExam] CHECK CONSTRAINT [TakeExam_fk0]
GO
ALTER TABLE [TakeExam] WITH CHECK ADD CONSTRAINT [TakeExam_fk1] FOREIGN KEY ([exam_id]) REFERENCES [Exam]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [TakeExam] CHECK CONSTRAINT [TakeExam_fk1]
GO

INSERT INTO Admin(email, password) values('admin@admin.com', '123456')