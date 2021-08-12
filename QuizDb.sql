CREATE TABLE [Student] (
	id integer NOT NULL,
	name varchar(35) NOT NULL,
	surname varchar(35) NOT NULL,
	email varchar(150) NOT NULL UNIQUE,
	password varchar(150) NOT NULL UNIQUE,
  CONSTRAINT [PK_STUDENT] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Teacher] (
	id integer NOT NULL,
	name varchar(35) NOT NULL,
	surname varchar(35) NOT NULL,
	email varchar(150) NOT NULL UNIQUE,
	password varchar(150) NOT NULL,
  CONSTRAINT [PK_TEACHER] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Admin] (
	id integer NOT NULL,
	email varchar(150) NOT NULL UNIQUE,
	password varchar(150) NOT NULL UNIQUE,
  CONSTRAINT [PK_ADMIN] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Exam] (
	id integer NOT NULL,
	title varchar(155) NOT NULL,
  CONSTRAINT [PK_EXAM] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Question] (
	id integer NOT NULL,
	Text text NOT NULL,
	correctVariant varchar(1) NOT NULL,
	ExamID integer NOT NULL,
  CONSTRAINT [PK_QUESTION] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Variant] (
	id integer NOT NULL,
	variantType varchar(1) NOT NULL,
	variantText text NOT NULL,
	question›d integer NOT NULL,
  CONSTRAINT [PK_VARIANT] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [TakeExam] (
	id integer NOT NULL,
	student_id integer NOT NULL,
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

ALTER TABLE [Variant] WITH CHECK ADD CONSTRAINT [Variant_fk0] FOREIGN KEY ([question›d]) REFERENCES [Question]([id])
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
