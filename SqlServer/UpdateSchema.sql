
    SET ANSI_NULLS ON
    GO

    SET QUOTED_IDENTIFIER ON
    GO
    
    
      -- TABLE: Applicant
      -- TABLE: Interviewer
      -- TABLE: Position

      -- CREATE DATABASE
      IF NOT EXISTS (SELECT * from sys.databases WHERE name = 'AirtableApplicantTracking')
      BEGIN
          CREATE DATABASE [AirtableApplicantTracking];
      END
        GO
        
     USE [AirtableApplicantTracking];
GO
      
        -- TABLE: Applicant
        -- ****** Object:  Table [dbo].[Applicant]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Applicant]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Applicant] (
          [ApplicantId] NVARCHAR(150) NOT NULL
          -- TEXT.
        ,
          [OnsiteInterviewer] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [OnsiteInterviewScore] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [PhoneScreenInterviewer] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [PhoneScreenNotes] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [Applyingfor] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [EmailAddress] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [PhoneScreenScore] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [OnsiteInterviewDate] DATE NULL
          -- xs:date.
        ,
          [Stage] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [OnsiteInterviewNotes] NVARCHAR(max) NULL
          -- TEXT.
        ,
          [Phone] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [PhoneScreenDate] DATE NULL
          -- xs:date.
        ,
          [Name] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [createdTime] DATETIME NULL
          -- DATETIME.
        ,
        
        CONSTRAINT [PK_Applicant] PRIMARY KEY CLUSTERED
          (
            [ApplicantId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Interviewer
        -- ****** Object:  Table [dbo].[Interviewer]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Interviewer]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Interviewer] (
          [InterviewerId] NVARCHAR(150) NOT NULL
          -- TEXT.
        ,
          [Name] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [createdTime] DATETIME NULL
          -- DATETIME.
        ,
        
        CONSTRAINT [PK_Interviewer] PRIMARY KEY CLUSTERED
          (
            [InterviewerId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Position
        -- ****** Object:  Table [dbo].[Position]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Position]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Position] (
          [PositionId] NVARCHAR(150) NOT NULL
          -- TEXT.
        ,
          [RequiredExperience] NVARCHAR(200) NULL
          -- TEXT.
        ,
          [Name] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [Description] NVARCHAR(150) NULL
          -- TEXT.
        ,
          [createdTime] DATETIME NULL
          -- DATETIME.
        ,
        
        CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED
          (
            [PositionId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO


      
DECLARE @ObjectName NVARCHAR(100)

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ApplicantId' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [ApplicantId] NVARCHAR(150) NULL;
    END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'OnsiteInterviewer' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [OnsiteInterviewer] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [OnsiteInterviewer] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'OnsiteInterviewScore' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [OnsiteInterviewScore] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [OnsiteInterviewScore] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'PhoneScreenInterviewer' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [PhoneScreenInterviewer] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [PhoneScreenInterviewer] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'PhoneScreenNotes' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [PhoneScreenNotes] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [PhoneScreenNotes] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Applyingfor' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [Applyingfor] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [Applyingfor] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'EmailAddress' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [EmailAddress] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [EmailAddress] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'PhoneScreenScore' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [PhoneScreenScore] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [PhoneScreenScore] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'OnsiteInterviewDate' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [OnsiteInterviewDate] DATE NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [OnsiteInterviewDate] DATE NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Stage' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [Stage] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [Stage] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'OnsiteInterviewNotes' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [OnsiteInterviewNotes] NVARCHAR(max) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [OnsiteInterviewNotes] NVARCHAR(max) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Phone' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [Phone] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [Phone] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'PhoneScreenDate' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [PhoneScreenDate] DATE NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [PhoneScreenDate] DATE NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [Name] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [Name] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 15
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'createdTime' AND Object_ID = Object_ID(N'Applicant'))
    BEGIN
            ALTER TABLE [dbo].[Applicant] ADD [createdTime] DATETIME NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Applicant] ALTER COLUMN [createdTime] DATETIME NULL;

    

	END

    
    -- COUNT: 5
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'InterviewerId' AND Object_ID = Object_ID(N'Interviewer'))
    BEGIN
            ALTER TABLE [dbo].[Interviewer] ADD [InterviewerId] NVARCHAR(150) NULL;
    END

    
    -- COUNT: 5
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Interviewer'))
    BEGIN
            ALTER TABLE [dbo].[Interviewer] ADD [Name] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Interviewer] ALTER COLUMN [Name] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 5
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'createdTime' AND Object_ID = Object_ID(N'Interviewer'))
    BEGIN
            ALTER TABLE [dbo].[Interviewer] ADD [createdTime] DATETIME NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Interviewer] ALTER COLUMN [createdTime] DATETIME NULL;

    

	END

    
    -- COUNT: 6
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'PositionId' AND Object_ID = Object_ID(N'Position'))
    BEGIN
            ALTER TABLE [dbo].[Position] ADD [PositionId] NVARCHAR(150) NULL;
    END

    
    -- COUNT: 6
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'RequiredExperience' AND Object_ID = Object_ID(N'Position'))
    BEGIN
            ALTER TABLE [dbo].[Position] ADD [RequiredExperience] NVARCHAR(200) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Position] ALTER COLUMN [RequiredExperience] NVARCHAR(200) NULL;

    

	END

    
    -- COUNT: 6
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Position'))
    BEGIN
            ALTER TABLE [dbo].[Position] ADD [Name] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Position] ALTER COLUMN [Name] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 6
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Position'))
    BEGIN
            ALTER TABLE [dbo].[Position] ADD [Description] NVARCHAR(150) NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Position] ALTER COLUMN [Description] NVARCHAR(150) NULL;

    

	END

    
    -- COUNT: 6
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'createdTime' AND Object_ID = Object_ID(N'Position'))
    BEGIN
            ALTER TABLE [dbo].[Position] ADD [createdTime] DATETIME NULL;
    END

    
    ELSE
    BEGIN 


        ALTER TABLE [dbo].[Position] ALTER COLUMN [createdTime] DATETIME NULL;

    

	END

    

              -- ****** KEYS FOR Table [dbo].[Applicant]
          -- FK for OnsiteInterviewer :: 0 :: Applicant :: Interviewer
          IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Applicant_OnsiteInterviewer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Applicant]'))
              IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Applicant_Interviewer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Applicant]'))
                ALTER TABLE [dbo].[Applicant]  WITH CHECK ADD  CONSTRAINT [FK_Applicant_OnsiteInterviewer] FOREIGN KEY([OnsiteInterviewer])
                    REFERENCES [dbo].[Interviewer] (InterviewerId)
                GO

          IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Applicant_OnsiteInterviewer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Applicant]'))
            ALTER TABLE [dbo].[Applicant] CHECK CONSTRAINT [FK_Applicant_OnsiteInterviewer]
            GO
          
          -- FK for PhoneScreenInterviewer :: 0 :: Applicant :: Interviewer
          IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Applicant_PhoneScreenInterviewer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Applicant]'))
              IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Applicant_Interviewer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Applicant]'))
                ALTER TABLE [dbo].[Applicant]  WITH CHECK ADD  CONSTRAINT [FK_Applicant_PhoneScreenInterviewer] FOREIGN KEY([PhoneScreenInterviewer])
                    REFERENCES [dbo].[Interviewer] (InterviewerId)
                GO

          IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Applicant_PhoneScreenInterviewer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Applicant]'))
            ALTER TABLE [dbo].[Applicant] CHECK CONSTRAINT [FK_Applicant_PhoneScreenInterviewer]
            GO
          
          -- FK for Applyingfor :: 0 :: Applicant :: Position
          IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Applicant_Position]') AND parent_object_id = OBJECT_ID(N'[dbo].[Applicant]'))
              IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Applicant_Position]') AND parent_object_id = OBJECT_ID(N'[dbo].[Applicant]'))
                ALTER TABLE [dbo].[Applicant]  WITH CHECK ADD  CONSTRAINT [FK_Applicant_Position] FOREIGN KEY([Applyingfor])
                    REFERENCES [dbo].[Position] (PositionId)
                GO

          IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Applicant_Position]') AND parent_object_id = OBJECT_ID(N'[dbo].[Applicant]'))
            ALTER TABLE [dbo].[Applicant] CHECK CONSTRAINT [FK_Applicant_Position]
            GO
          

              -- ****** KEYS FOR Table [dbo].[Interviewer]

              -- ****** KEYS FOR Table [dbo].[Position]


            SELECT 'Successful' as Value
            FROM (SELECT NULL AS FIELD) as Result
            FOR XML AUTO

          