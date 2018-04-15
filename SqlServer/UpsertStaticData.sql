
 -- INSERT DATA
  
        
        
        
        
        
            -- INSERT: Applicant
            --  STATIC: 
            --  Rows: 3
            --  only-static-data: false
            
        
                

                    -- INSERT VALUES
                    IF NOT EXISTS (SELECT ApplicantId FROM Applicant WHERE ApplicantId = 'rec74Fa5aYDeGsDOR')
                    BEGIN
                        INSERT INTO [Applicant] ([ApplicantId] , [OnsiteInterviewScore] , [PhoneScreenNotes] , [EmailAddress] , [PhoneScreenScore] , [OnsiteInterviewDate] , [Stage] , [OnsiteInterviewNotes] , [Phone] , [PhoneScreenDate] , [Name] , [createdTime] ) VALUES (
                        
                                'rec74Fa5aYDeGsDOR', 
                        
                                '2 - worth consideration', 
                        
                                'Questionable, but tentatively move to on-site interview', 
                        
                                'c.potato@example.com', 
                        
                                '2 - worth consideration', 
                        
                                '2013-02-14', 
                        
                                'Decision Needed', 
                        
                                'Seems like a really hard worker, and has a great attitude. Very observant: He''s got eyes everywhere. But I am concerned that he won''t be able to think outside the bag.', 
                        
                                '(208) 555-0505', 
                        
                                '2013-02-07', 
                        
                                'Chippy the Potato', 
                        
                                '2015-11-11T23:05:58Z');
                    END ELSE BEGIN
                        UPDATE  [Applicant] 
                            SET 
                                [OnsiteInterviewScore] = '2 - worth consideration', 
                                [PhoneScreenNotes] = 'Questionable, but tentatively move to on-site interview', 
                                [EmailAddress] = 'c.potato@example.com', 
                                [PhoneScreenScore] = '2 - worth consideration', 
                                [OnsiteInterviewDate] = '2013-02-14', 
                                [Stage] = 'Decision Needed', 
                                [OnsiteInterviewNotes] = 'Seems like a really hard worker, and has a great attitude. Very observant: He''s got eyes everywhere. But I am concerned that he won''t be able to think outside the bag.', 
                                [Phone] = '(208) 555-0505', 
                                [PhoneScreenDate] = '2013-02-07', 
                                [Name] = 'Chippy the Potato', 
                                [createdTime] = '2015-11-11T23:05:58Z'
                        WHERE ApplicantId = 'rec74Fa5aYDeGsDOR';
                    END
                

                    -- INSERT VALUES
                    IF NOT EXISTS (SELECT ApplicantId FROM Applicant WHERE ApplicantId = 'rec9yA61jdUavkP63')
                    BEGIN
                        INSERT INTO [Applicant] ([ApplicantId] , [OnsiteInterviewScore] , [PhoneScreenNotes] , [EmailAddress] , [PhoneScreenScore] , [OnsiteInterviewDate] , [Stage] , [OnsiteInterviewNotes] , [Phone] , [PhoneScreenDate] , [Name] , [createdTime] ) VALUES (
                        
                                'rec9yA61jdUavkP63', 
                        
                                '3 - good candidate', 
                        
                                'Good analytical skills, very articulate. Proceed to in-person interview.', 
                        
                                'ohuxley@example.com', 
                        
                                '3 - good candidate', 
                        
                                '2013-02-19', 
                        
                                'Interviewing', 
                        
                                'Owldous was impressive overall, and he has a lot of experience in the corporate world. But if he were to join with a sports team, he''d still have a lot to learn about the industry, e.g., I asked him for his opinion on Leon the Lion''s recent resignation and he responded, "Whooo?"', 
                        
                                '(646) 555-4389', 
                        
                                '2013-02-11', 
                        
                                'Owldous Huxley', 
                        
                                '2015-11-11T23:19:11Z');
                    END ELSE BEGIN
                        UPDATE  [Applicant] 
                            SET 
                                [OnsiteInterviewScore] = '3 - good candidate', 
                                [PhoneScreenNotes] = 'Good analytical skills, very articulate. Proceed to in-person interview.', 
                                [EmailAddress] = 'ohuxley@example.com', 
                                [PhoneScreenScore] = '3 - good candidate', 
                                [OnsiteInterviewDate] = '2013-02-19', 
                                [Stage] = 'Interviewing', 
                                [OnsiteInterviewNotes] = 'Owldous was impressive overall, and he has a lot of experience in the corporate world. But if he were to join with a sports team, he''d still have a lot to learn about the industry, e.g., I asked him for his opinion on Leon the Lion''s recent resignation and he responded, "Whooo?"', 
                                [Phone] = '(646) 555-4389', 
                                [PhoneScreenDate] = '2013-02-11', 
                                [Name] = 'Owldous Huxley', 
                                [createdTime] = '2015-11-11T23:19:11Z'
                        WHERE ApplicantId = 'rec9yA61jdUavkP63';
                    END
                

                    -- INSERT VALUES
                    IF NOT EXISTS (SELECT ApplicantId FROM Applicant WHERE ApplicantId = 'recO2MUWJvM6xIauT')
                    BEGIN
                        INSERT INTO [Applicant] ([ApplicantId] , [OnsiteInterviewScore] , [PhoneScreenNotes] , [EmailAddress] , [PhoneScreenScore] , [OnsiteInterviewDate] , [Stage] , [OnsiteInterviewNotes] , [Phone] , [PhoneScreenDate] , [Name] , [createdTime] ) VALUES (
                        
                                'recO2MUWJvM6xIauT', 
                        
                                '2 - worth consideration', 
                        
                                'Move to in-person.', 
                        
                                'hrmqueenlizzy@example.com', 
                        
                                '3 - good candidate', 
                        
                                '2013-02-17', 
                        
                                'Decision Needed', 
                        
                                'Liz was highly qualified, but seemed shifty. When faced with a question she was uncomfortable with, she slithered out of it. Could be someone that is very smart, but difficult to deal with. Not sure that she''s a team player, which of course is a problem if you''re going to be representing a team.', 
                        
                                '(865) 123-4567', 
                        
                                '2013-02-12', 
                        
                                'Queen Elizardbeth II', 
                        
                                '2015-11-11T23:11:29Z');
                    END ELSE BEGIN
                        UPDATE  [Applicant] 
                            SET 
                                [OnsiteInterviewScore] = '2 - worth consideration', 
                                [PhoneScreenNotes] = 'Move to in-person.', 
                                [EmailAddress] = 'hrmqueenlizzy@example.com', 
                                [PhoneScreenScore] = '3 - good candidate', 
                                [OnsiteInterviewDate] = '2013-02-17', 
                                [Stage] = 'Decision Needed', 
                                [OnsiteInterviewNotes] = 'Liz was highly qualified, but seemed shifty. When faced with a question she was uncomfortable with, she slithered out of it. Could be someone that is very smart, but difficult to deal with. Not sure that she''s a team player, which of course is a problem if you''re going to be representing a team.', 
                                [Phone] = '(865) 123-4567', 
                                [PhoneScreenDate] = '2013-02-12', 
                                [Name] = 'Queen Elizardbeth II', 
                                [createdTime] = '2015-11-11T23:11:29Z'
                        WHERE ApplicantId = 'recO2MUWJvM6xIauT';
                    END
                
            
 
        
        
        
        
        
            -- INSERT: Interviewer
            --  STATIC: 
            --  Rows: 3
            --  only-static-data: false
            
        
                

                    -- INSERT VALUES
                    IF NOT EXISTS (SELECT InterviewerId FROM Interviewer WHERE InterviewerId = 'recDj5pGdmAascx0j')
                    BEGIN
                        INSERT INTO [Interviewer] ([InterviewerId] , [Name] , [createdTime] ) VALUES (
                        
                                'recDj5pGdmAascx0j', 
                        
                                'Ari Bloom', 
                        
                                '2013-02-22T02:49:28Z');
                    END ELSE BEGIN
                        UPDATE  [Interviewer] 
                            SET 
                                [Name] = 'Ari Bloom', 
                                [createdTime] = '2013-02-22T02:49:28Z'
                        WHERE InterviewerId = 'recDj5pGdmAascx0j';
                    END
                

                    -- INSERT VALUES
                    IF NOT EXISTS (SELECT InterviewerId FROM Interviewer WHERE InterviewerId = 'recEn6wJamtbp6yYx')
                    BEGIN
                        INSERT INTO [Interviewer] ([InterviewerId] , [Name] , [createdTime] ) VALUES (
                        
                                'recEn6wJamtbp6yYx', 
                        
                                'Kareena Mukherjee', 
                        
                                '2013-02-22T02:49:24Z');
                    END ELSE BEGIN
                        UPDATE  [Interviewer] 
                            SET 
                                [Name] = 'Kareena Mukherjee', 
                                [createdTime] = '2013-02-22T02:49:24Z'
                        WHERE InterviewerId = 'recEn6wJamtbp6yYx';
                    END
                

                    -- INSERT VALUES
                    IF NOT EXISTS (SELECT InterviewerId FROM Interviewer WHERE InterviewerId = 'recud3pL3oEhpjxZq')
                    BEGIN
                        INSERT INTO [Interviewer] ([InterviewerId] , [Name] , [createdTime] ) VALUES (
                        
                                'recud3pL3oEhpjxZq', 
                        
                                'Andy Park', 
                        
                                '2013-02-22T02:49:27Z');
                    END ELSE BEGIN
                        UPDATE  [Interviewer] 
                            SET 
                                [Name] = 'Andy Park', 
                                [createdTime] = '2013-02-22T02:49:27Z'
                        WHERE InterviewerId = 'recud3pL3oEhpjxZq';
                    END
                
            
 
        
        
        
        
        
            -- INSERT: Position
            --  STATIC: 
            --  Rows: 2
            --  only-static-data: false
            
        
                

                    -- INSERT VALUES
                    IF NOT EXISTS (SELECT PositionId FROM Position WHERE PositionId = 'recfFXa7EMG8lXLJy')
                    BEGIN
                        INSERT INTO [Position] ([PositionId] , [RequiredExperience] , [Name] , [Description] , [createdTime] ) VALUES (
                        
                                'recfFXa7EMG8lXLJy', 
                        
                                'Requires a B.A. in Mascot Arts and 2 years of work experience. Experience with the food and beverage industry a plus.', 
                        
                                'Concessions Mascot', 
                        
                                'Responsible for improving fan engagement with respect to concessions sales.', 
                        
                                '2015-11-11T18:58:29Z');
                    END ELSE BEGIN
                        UPDATE  [Position] 
                            SET 
                                [RequiredExperience] = 'Requires a B.A. in Mascot Arts and 2 years of work experience. Experience with the food and beverage industry a plus.', 
                                [Name] = 'Concessions Mascot', 
                                [Description] = 'Responsible for improving fan engagement with respect to concessions sales.', 
                                [createdTime] = '2015-11-11T18:58:29Z'
                        WHERE PositionId = 'recfFXa7EMG8lXLJy';
                    END
                

                    -- INSERT VALUES
                    IF NOT EXISTS (SELECT PositionId FROM Position WHERE PositionId = 'recxhwI5DfeDIDA2w')
                    BEGIN
                        INSERT INTO [Position] ([PositionId] , [RequiredExperience] , [Name] , [Description] , [createdTime] ) VALUES (
                        
                                'recxhwI5DfeDIDA2w', 
                        
                                'At least 7 years of work as a mascot at a professional level, or 3 years of work as a mascot at a professional level and an M.A. in Mascot Arts.', 
                        
                                'Lead Mascot', 
                        
                                'Represents entire team. Responsible for training other mascots.', 
                        
                                '2015-11-11T18:58:10Z');
                    END ELSE BEGIN
                        UPDATE  [Position] 
                            SET 
                                [RequiredExperience] = 'At least 7 years of work as a mascot at a professional level, or 3 years of work as a mascot at a professional level and an M.A. in Mascot Arts.', 
                                [Name] = 'Lead Mascot', 
                                [Description] = 'Represents entire team. Responsible for training other mascots.', 
                                [createdTime] = '2015-11-11T18:58:10Z'
                        WHERE PositionId = 'recxhwI5DfeDIDA2w';
                    END
                
            
 

-- ADD RELATIONSHIPS
   
        
        
        
        
        
            -- ADD ALL DATA FOR: Applicant
            --  STATIC: 
            --  Rows: 3
            --  only-static-data: false
            
        
                

                    IF NOT EXISTS (SELECT ApplicantId FROM Applicant WHERE ApplicantId = 'rec74Fa5aYDeGsDOR')
                    BEGIN
                        INSERT INTO [Applicant] ([ApplicantId] , [OnsiteInterviewer] , [OnsiteInterviewScore] , [PhoneScreenInterviewer] , [PhoneScreenNotes] , [Applyingfor] , [EmailAddress] , [PhoneScreenScore] , [OnsiteInterviewDate] , [Stage] , [OnsiteInterviewNotes] , [Phone] , [PhoneScreenDate] , [Name] , [createdTime] ) VALUES (
                        
                                'rec74Fa5aYDeGsDOR', 
                        
                                'recud3pL3oEhpjxZq', 
                        
                                '2 - worth consideration', 
                        
                                'recDj5pGdmAascx0j', 
                        
                                'Questionable, but tentatively move to on-site interview', 
                        
                                'recfFXa7EMG8lXLJy', 
                        
                                'c.potato@example.com', 
                        
                                '2 - worth consideration', 
                        
                                '2013-02-14', 
                        
                                'Decision Needed', 
                        
                                'Seems like a really hard worker, and has a great attitude. Very observant: He''s got eyes everywhere. But I am concerned that he won''t be able to think outside the bag.', 
                        
                                '(208) 555-0505', 
                        
                                '2013-02-07', 
                        
                                'Chippy the Potato', 
                        
                                '2015-11-11T23:05:58Z');
                    END ELSE BEGIN
                        UPDATE  [Applicant] 
                            SET 
                                [OnsiteInterviewer] = 'recud3pL3oEhpjxZq', 
                                [OnsiteInterviewScore] = '2 - worth consideration', 
                                [PhoneScreenInterviewer] = 'recDj5pGdmAascx0j', 
                                [PhoneScreenNotes] = 'Questionable, but tentatively move to on-site interview', 
                                [Applyingfor] = 'recfFXa7EMG8lXLJy', 
                                [EmailAddress] = 'c.potato@example.com', 
                                [PhoneScreenScore] = '2 - worth consideration', 
                                [OnsiteInterviewDate] = '2013-02-14', 
                                [Stage] = 'Decision Needed', 
                                [OnsiteInterviewNotes] = 'Seems like a really hard worker, and has a great attitude. Very observant: He''s got eyes everywhere. But I am concerned that he won''t be able to think outside the bag.', 
                                [Phone] = '(208) 555-0505', 
                                [PhoneScreenDate] = '2013-02-07', 
                                [Name] = 'Chippy the Potato', 
                                [createdTime] = '2015-11-11T23:05:58Z'
                        WHERE ApplicantId = 'rec74Fa5aYDeGsDOR';
                    END
                

                    IF NOT EXISTS (SELECT ApplicantId FROM Applicant WHERE ApplicantId = 'rec9yA61jdUavkP63')
                    BEGIN
                        INSERT INTO [Applicant] ([ApplicantId] , [OnsiteInterviewer] , [OnsiteInterviewScore] , [PhoneScreenInterviewer] , [PhoneScreenNotes] , [Applyingfor] , [EmailAddress] , [PhoneScreenScore] , [OnsiteInterviewDate] , [Stage] , [OnsiteInterviewNotes] , [Phone] , [PhoneScreenDate] , [Name] , [createdTime] ) VALUES (
                        
                                'rec9yA61jdUavkP63', 
                        
                                'recud3pL3oEhpjxZq', 
                        
                                '3 - good candidate', 
                        
                                'recEn6wJamtbp6yYx', 
                        
                                'Good analytical skills, very articulate. Proceed to in-person interview.', 
                        
                                'recxhwI5DfeDIDA2w', 
                        
                                'ohuxley@example.com', 
                        
                                '3 - good candidate', 
                        
                                '2013-02-19', 
                        
                                'Interviewing', 
                        
                                'Owldous was impressive overall, and he has a lot of experience in the corporate world. But if he were to join with a sports team, he''d still have a lot to learn about the industry, e.g., I asked him for his opinion on Leon the Lion''s recent resignation and he responded, "Whooo?"', 
                        
                                '(646) 555-4389', 
                        
                                '2013-02-11', 
                        
                                'Owldous Huxley', 
                        
                                '2015-11-11T23:19:11Z');
                    END ELSE BEGIN
                        UPDATE  [Applicant] 
                            SET 
                                [OnsiteInterviewer] = 'recud3pL3oEhpjxZq', 
                                [OnsiteInterviewScore] = '3 - good candidate', 
                                [PhoneScreenInterviewer] = 'recEn6wJamtbp6yYx', 
                                [PhoneScreenNotes] = 'Good analytical skills, very articulate. Proceed to in-person interview.', 
                                [Applyingfor] = 'recxhwI5DfeDIDA2w', 
                                [EmailAddress] = 'ohuxley@example.com', 
                                [PhoneScreenScore] = '3 - good candidate', 
                                [OnsiteInterviewDate] = '2013-02-19', 
                                [Stage] = 'Interviewing', 
                                [OnsiteInterviewNotes] = 'Owldous was impressive overall, and he has a lot of experience in the corporate world. But if he were to join with a sports team, he''d still have a lot to learn about the industry, e.g., I asked him for his opinion on Leon the Lion''s recent resignation and he responded, "Whooo?"', 
                                [Phone] = '(646) 555-4389', 
                                [PhoneScreenDate] = '2013-02-11', 
                                [Name] = 'Owldous Huxley', 
                                [createdTime] = '2015-11-11T23:19:11Z'
                        WHERE ApplicantId = 'rec9yA61jdUavkP63';
                    END
                

                    IF NOT EXISTS (SELECT ApplicantId FROM Applicant WHERE ApplicantId = 'recO2MUWJvM6xIauT')
                    BEGIN
                        INSERT INTO [Applicant] ([ApplicantId] , [OnsiteInterviewer] , [OnsiteInterviewScore] , [PhoneScreenInterviewer] , [PhoneScreenNotes] , [Applyingfor] , [EmailAddress] , [PhoneScreenScore] , [OnsiteInterviewDate] , [Stage] , [OnsiteInterviewNotes] , [Phone] , [PhoneScreenDate] , [Name] , [createdTime] ) VALUES (
                        
                                'recO2MUWJvM6xIauT', 
                        
                                'recDj5pGdmAascx0j', 
                        
                                '2 - worth consideration', 
                        
                                'recEn6wJamtbp6yYx', 
                        
                                'Move to in-person.', 
                        
                                'recxhwI5DfeDIDA2w', 
                        
                                'hrmqueenlizzy@example.com', 
                        
                                '3 - good candidate', 
                        
                                '2013-02-17', 
                        
                                'Decision Needed', 
                        
                                'Liz was highly qualified, but seemed shifty. When faced with a question she was uncomfortable with, she slithered out of it. Could be someone that is very smart, but difficult to deal with. Not sure that she''s a team player, which of course is a problem if you''re going to be representing a team.', 
                        
                                '(865) 123-4567', 
                        
                                '2013-02-12', 
                        
                                'Queen Elizardbeth II', 
                        
                                '2015-11-11T23:11:29Z');
                    END ELSE BEGIN
                        UPDATE  [Applicant] 
                            SET 
                                [OnsiteInterviewer] = 'recDj5pGdmAascx0j', 
                                [OnsiteInterviewScore] = '2 - worth consideration', 
                                [PhoneScreenInterviewer] = 'recEn6wJamtbp6yYx', 
                                [PhoneScreenNotes] = 'Move to in-person.', 
                                [Applyingfor] = 'recxhwI5DfeDIDA2w', 
                                [EmailAddress] = 'hrmqueenlizzy@example.com', 
                                [PhoneScreenScore] = '3 - good candidate', 
                                [OnsiteInterviewDate] = '2013-02-17', 
                                [Stage] = 'Decision Needed', 
                                [OnsiteInterviewNotes] = 'Liz was highly qualified, but seemed shifty. When faced with a question she was uncomfortable with, she slithered out of it. Could be someone that is very smart, but difficult to deal with. Not sure that she''s a team player, which of course is a problem if you''re going to be representing a team.', 
                                [Phone] = '(865) 123-4567', 
                                [PhoneScreenDate] = '2013-02-12', 
                                [Name] = 'Queen Elizardbeth II', 
                                [createdTime] = '2015-11-11T23:11:29Z'
                        WHERE ApplicantId = 'recO2MUWJvM6xIauT';
                    END
                
            
 
        
        
        
        
        
            -- ADD ALL DATA FOR: Interviewer
            --  STATIC: 
            --  Rows: 3
            --  only-static-data: false
            
        
                

                    IF NOT EXISTS (SELECT InterviewerId FROM Interviewer WHERE InterviewerId = 'recDj5pGdmAascx0j')
                    BEGIN
                        INSERT INTO [Interviewer] ([InterviewerId] , [Name] , [createdTime] ) VALUES (
                        
                                'recDj5pGdmAascx0j', 
                        
                                'Ari Bloom', 
                        
                                '2013-02-22T02:49:28Z');
                    END ELSE BEGIN
                        UPDATE  [Interviewer] 
                            SET 
                                [Name] = 'Ari Bloom', 
                                [createdTime] = '2013-02-22T02:49:28Z'
                        WHERE InterviewerId = 'recDj5pGdmAascx0j';
                    END
                

                    IF NOT EXISTS (SELECT InterviewerId FROM Interviewer WHERE InterviewerId = 'recEn6wJamtbp6yYx')
                    BEGIN
                        INSERT INTO [Interviewer] ([InterviewerId] , [Name] , [createdTime] ) VALUES (
                        
                                'recEn6wJamtbp6yYx', 
                        
                                'Kareena Mukherjee', 
                        
                                '2013-02-22T02:49:24Z');
                    END ELSE BEGIN
                        UPDATE  [Interviewer] 
                            SET 
                                [Name] = 'Kareena Mukherjee', 
                                [createdTime] = '2013-02-22T02:49:24Z'
                        WHERE InterviewerId = 'recEn6wJamtbp6yYx';
                    END
                

                    IF NOT EXISTS (SELECT InterviewerId FROM Interviewer WHERE InterviewerId = 'recud3pL3oEhpjxZq')
                    BEGIN
                        INSERT INTO [Interviewer] ([InterviewerId] , [Name] , [createdTime] ) VALUES (
                        
                                'recud3pL3oEhpjxZq', 
                        
                                'Andy Park', 
                        
                                '2013-02-22T02:49:27Z');
                    END ELSE BEGIN
                        UPDATE  [Interviewer] 
                            SET 
                                [Name] = 'Andy Park', 
                                [createdTime] = '2013-02-22T02:49:27Z'
                        WHERE InterviewerId = 'recud3pL3oEhpjxZq';
                    END
                
            
 
        
        
        
        
        
            -- ADD ALL DATA FOR: Position
            --  STATIC: 
            --  Rows: 2
            --  only-static-data: false
            
        
                

                    IF NOT EXISTS (SELECT PositionId FROM Position WHERE PositionId = 'recfFXa7EMG8lXLJy')
                    BEGIN
                        INSERT INTO [Position] ([PositionId] , [RequiredExperience] , [Name] , [Description] , [createdTime] ) VALUES (
                        
                                'recfFXa7EMG8lXLJy', 
                        
                                'Requires a B.A. in Mascot Arts and 2 years of work experience. Experience with the food and beverage industry a plus.', 
                        
                                'Concessions Mascot', 
                        
                                'Responsible for improving fan engagement with respect to concessions sales.', 
                        
                                '2015-11-11T18:58:29Z');
                    END ELSE BEGIN
                        UPDATE  [Position] 
                            SET 
                                [RequiredExperience] = 'Requires a B.A. in Mascot Arts and 2 years of work experience. Experience with the food and beverage industry a plus.', 
                                [Name] = 'Concessions Mascot', 
                                [Description] = 'Responsible for improving fan engagement with respect to concessions sales.', 
                                [createdTime] = '2015-11-11T18:58:29Z'
                        WHERE PositionId = 'recfFXa7EMG8lXLJy';
                    END
                

                    IF NOT EXISTS (SELECT PositionId FROM Position WHERE PositionId = 'recxhwI5DfeDIDA2w')
                    BEGIN
                        INSERT INTO [Position] ([PositionId] , [RequiredExperience] , [Name] , [Description] , [createdTime] ) VALUES (
                        
                                'recxhwI5DfeDIDA2w', 
                        
                                'At least 7 years of work as a mascot at a professional level, or 3 years of work as a mascot at a professional level and an M.A. in Mascot Arts.', 
                        
                                'Lead Mascot', 
                        
                                'Represents entire team. Responsible for training other mascots.', 
                        
                                '2015-11-11T18:58:10Z');
                    END ELSE BEGIN
                        UPDATE  [Position] 
                            SET 
                                [RequiredExperience] = 'At least 7 years of work as a mascot at a professional level, or 3 years of work as a mascot at a professional level and an M.A. in Mascot Arts.', 
                                [Name] = 'Lead Mascot', 
                                [Description] = 'Represents entire team. Responsible for training other mascots.', 
                                [createdTime] = '2015-11-11T18:58:10Z'
                        WHERE PositionId = 'recxhwI5DfeDIDA2w';
                    END
                
            
 
                