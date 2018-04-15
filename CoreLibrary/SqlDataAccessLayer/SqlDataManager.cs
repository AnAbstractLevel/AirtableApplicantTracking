/************************************************
 CODEE42 - AUTO GENERATED FILE - DO NOT OVERWRITE
 ************************************************
 Created By: EJ Alexandra - 2016
             An Abstract Level, llc
 License:    Mozilla Public License 2.0
 ************************************************
 CODEE42 - AUTO GENERATED FILE - DO NOT OVERWRITE
 ************************************************/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

using AirtableApplicantTracking.Lib.DataClasses;

using CoreLibrary.Extensions;

namespace AirtableApplicantTracking.Lib.SqlDataManagement
{
    public partial class SqlDataManager : IDisposable
    {
        public SqlDataManager() : this(SqlDataManager.LastConnectionString) 
        {
            this.Schema = "dbo";
        }
    
        public SqlDataManager(String connectionString)
        {
            this.Schema = "dbo";
            this.ConnectionString = connectionString;
            if (String.IsNullOrEmpty(this.ConnectionString))
            {
                this.ConnectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            }
        }

        public SqlDataManager(String dataSourceName, String dbName) 
        {
            this.Schema = "dbo";
            this.DataSourceName = dataSourceName;
            this.DBName = dbName;
        }
        
        public void Dispose() 
        {
            this.IsDisposed = true;
        }
        
        public static string LastConnectionString { get; set; }
        public string ConnectionString { get; set; }
        public String DataSourceName { get; set; }
        public String DBName { get; set; }
        public Boolean IsDisposed { get; set; }
        public String Schema { get; set; }
        

  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Applicant applicant)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Applicant] (ApplicantId, OnsiteInterviewer, OnsiteInterviewScore, PhoneScreenInterviewer, PhoneScreenNotes, Applyingfor, EmailAddress, PhoneScreenScore, OnsiteInterviewDate, Stage, OnsiteInterviewNotes, Phone, PhoneScreenDate, Name, createdTime)
                                    VALUES (@ApplicantId, @OnsiteInterviewer, @OnsiteInterviewScore, @PhoneScreenInterviewer, @PhoneScreenNotes, @Applyingfor, @EmailAddress, @PhoneScreenScore, @OnsiteInterviewDate, @Stage, @OnsiteInterviewNotes, @Phone, @PhoneScreenDate, @Name, @createdTime)", this.Schema);

                
                  
                if (ReferenceEquals(applicant.ApplicantId, null)) cmd.Parameters.AddWithValue("@ApplicantId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ApplicantId", applicant.ApplicantId);
                
                  
                if (ReferenceEquals(applicant.OnsiteInterviewer, null)) cmd.Parameters.AddWithValue("@OnsiteInterviewer", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OnsiteInterviewer", applicant.OnsiteInterviewer);
                
                  
                if (ReferenceEquals(applicant.OnsiteInterviewScore, null)) cmd.Parameters.AddWithValue("@OnsiteInterviewScore", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OnsiteInterviewScore", applicant.OnsiteInterviewScore);
                
                  
                if (ReferenceEquals(applicant.PhoneScreenInterviewer, null)) cmd.Parameters.AddWithValue("@PhoneScreenInterviewer", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PhoneScreenInterviewer", applicant.PhoneScreenInterviewer);
                
                  
                if (ReferenceEquals(applicant.PhoneScreenNotes, null)) cmd.Parameters.AddWithValue("@PhoneScreenNotes", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PhoneScreenNotes", applicant.PhoneScreenNotes);
                
                  
                if (ReferenceEquals(applicant.Applyingfor, null)) cmd.Parameters.AddWithValue("@Applyingfor", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Applyingfor", applicant.Applyingfor);
                
                  
                if (ReferenceEquals(applicant.EmailAddress, null)) cmd.Parameters.AddWithValue("@EmailAddress", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@EmailAddress", applicant.EmailAddress);
                
                  
                if (ReferenceEquals(applicant.PhoneScreenScore, null)) cmd.Parameters.AddWithValue("@PhoneScreenScore", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PhoneScreenScore", applicant.PhoneScreenScore);
                
                  
                if (ReferenceEquals(applicant.OnsiteInterviewDate, null)) cmd.Parameters.AddWithValue("@OnsiteInterviewDate", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OnsiteInterviewDate", applicant.OnsiteInterviewDate);
                
                  
                if (ReferenceEquals(applicant.Stage, null)) cmd.Parameters.AddWithValue("@Stage", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Stage", applicant.Stage);
                
                  
                if (ReferenceEquals(applicant.OnsiteInterviewNotes, null)) cmd.Parameters.AddWithValue("@OnsiteInterviewNotes", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OnsiteInterviewNotes", applicant.OnsiteInterviewNotes);
                
                  
                if (ReferenceEquals(applicant.Phone, null)) cmd.Parameters.AddWithValue("@Phone", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Phone", applicant.Phone);
                
                  
                if (ReferenceEquals(applicant.PhoneScreenDate, null)) cmd.Parameters.AddWithValue("@PhoneScreenDate", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PhoneScreenDate", applicant.PhoneScreenDate);
                
                  
                if (ReferenceEquals(applicant.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", applicant.Name);
                
                  
                if (ReferenceEquals(applicant.createdTime, null) ||
                    (applicant.createdTime == DateTime.MinValue)) cmd.Parameters.AddWithValue("@createdTime", DBNull.Value);
                  
                else cmd.Parameters.AddWithValue("@createdTime", applicant.createdTime);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Applicant applicant)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = applicant.ApplicantId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM [Applicant] WHERE ApplicantId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(applicant);
                else return this.Insert(applicant);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllApplicants<T>()
            where T : Applicant, new()
        {
            return this.GetAllApplicants<T>(String.Empty);
        }

        
        public List<T> GetAllApplicants<T>(String whereClause)
            where T : Applicant, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Applicant]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T applicant = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("ApplicantId");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.ApplicantId = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("OnsiteInterviewer");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.OnsiteInterviewer = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("OnsiteInterviewScore");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.OnsiteInterviewScore = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("PhoneScreenInterviewer");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.PhoneScreenInterviewer = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("PhoneScreenNotes");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.PhoneScreenNotes = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Applyingfor");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.Applyingfor = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("EmailAddress");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.EmailAddress = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("PhoneScreenScore");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.PhoneScreenScore = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("OnsiteInterviewDate");
                      if (!reader.IsDBNull(propertyIndex)) //XS:DATE
                      {
                          
                          applicant.OnsiteInterviewDate = reader.GetDateTime(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Stage");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.Stage = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("OnsiteInterviewNotes");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.OnsiteInterviewNotes = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Phone");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.Phone = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("PhoneScreenDate");
                      if (!reader.IsDBNull(propertyIndex)) //XS:DATE
                      {
                          
                          applicant.PhoneScreenDate = reader.GetDateTime(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          applicant.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("createdTime");
                      if (!reader.IsDBNull(propertyIndex)) //DATETIME
                      {
                          
                          applicant.createdTime = reader.GetDateTime(propertyIndex);
                      }
                   
                    results.Add(applicant);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Applicant
        /// </summary>
        /// <returns></returns>
        public int Update(Applicant applicant)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Applicant] SET 
                                    [OnsiteInterviewer] = @OnsiteInterviewer, [OnsiteInterviewScore] = @OnsiteInterviewScore, [PhoneScreenInterviewer] = @PhoneScreenInterviewer, [PhoneScreenNotes] = @PhoneScreenNotes, [Applyingfor] = @Applyingfor, [EmailAddress] = @EmailAddress, [PhoneScreenScore] = @PhoneScreenScore, [OnsiteInterviewDate] = @OnsiteInterviewDate, [Stage] = @Stage, [OnsiteInterviewNotes] = @OnsiteInterviewNotes, [Phone] = @Phone, [PhoneScreenDate] = @PhoneScreenDate, [Name] = @Name, [createdTime] = @createdTime
                                    WHERE  [ApplicantId] = @ApplicantId", this.Schema);

                 //TEXT
                
                if (ReferenceEquals(applicant.ApplicantId, null)) cmd.Parameters.AddWithValue("@ApplicantId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@ApplicantId", applicant.ApplicantId);
                 //TEXT
                
                if (ReferenceEquals(applicant.OnsiteInterviewer, null)) cmd.Parameters.AddWithValue("@OnsiteInterviewer", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OnsiteInterviewer", applicant.OnsiteInterviewer);
                 //TEXT
                
                if (ReferenceEquals(applicant.OnsiteInterviewScore, null)) cmd.Parameters.AddWithValue("@OnsiteInterviewScore", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OnsiteInterviewScore", applicant.OnsiteInterviewScore);
                 //TEXT
                
                if (ReferenceEquals(applicant.PhoneScreenInterviewer, null)) cmd.Parameters.AddWithValue("@PhoneScreenInterviewer", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PhoneScreenInterviewer", applicant.PhoneScreenInterviewer);
                 //TEXT
                
                if (ReferenceEquals(applicant.PhoneScreenNotes, null)) cmd.Parameters.AddWithValue("@PhoneScreenNotes", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PhoneScreenNotes", applicant.PhoneScreenNotes);
                 //TEXT
                
                if (ReferenceEquals(applicant.Applyingfor, null)) cmd.Parameters.AddWithValue("@Applyingfor", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Applyingfor", applicant.Applyingfor);
                 //TEXT
                
                if (ReferenceEquals(applicant.EmailAddress, null)) cmd.Parameters.AddWithValue("@EmailAddress", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@EmailAddress", applicant.EmailAddress);
                 //TEXT
                
                if (ReferenceEquals(applicant.PhoneScreenScore, null)) cmd.Parameters.AddWithValue("@PhoneScreenScore", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PhoneScreenScore", applicant.PhoneScreenScore);
                 //xs:date
                
                if (ReferenceEquals(applicant.OnsiteInterviewDate, null)) cmd.Parameters.AddWithValue("@OnsiteInterviewDate", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OnsiteInterviewDate", applicant.OnsiteInterviewDate);
                 //TEXT
                
                if (ReferenceEquals(applicant.Stage, null)) cmd.Parameters.AddWithValue("@Stage", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Stage", applicant.Stage);
                 //TEXT
                
                if (ReferenceEquals(applicant.OnsiteInterviewNotes, null)) cmd.Parameters.AddWithValue("@OnsiteInterviewNotes", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@OnsiteInterviewNotes", applicant.OnsiteInterviewNotes);
                 //TEXT
                
                if (ReferenceEquals(applicant.Phone, null)) cmd.Parameters.AddWithValue("@Phone", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Phone", applicant.Phone);
                 //xs:date
                
                if (ReferenceEquals(applicant.PhoneScreenDate, null)) cmd.Parameters.AddWithValue("@PhoneScreenDate", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PhoneScreenDate", applicant.PhoneScreenDate);
                 //TEXT
                
                if (ReferenceEquals(applicant.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", applicant.Name);
                 //DATETIME
                
                if (ReferenceEquals(applicant.createdTime, null) ||
                    (applicant.createdTime == DateTime.MinValue)) cmd.Parameters.AddWithValue("@createdTime", DBNull.Value);
                  
                else cmd.Parameters.AddWithValue("@createdTime", applicant.createdTime);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Applicant
        /// </summary>
        /// <returns></returns>
        public int Delete(Applicant applicant)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Applicant] 
                                    WHERE  [ApplicantId] = @ApplicantId", this.Schema);
                                    
                
                if (ReferenceEquals(applicant.ApplicantId, null)) cmd.Parameters.AddWithValue("@ApplicantId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@ApplicantId", applicant.ApplicantId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Interviewer interviewer)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Interviewer] (InterviewerId, Name, createdTime)
                                    VALUES (@InterviewerId, @Name, @createdTime)", this.Schema);

                
                  
                if (ReferenceEquals(interviewer.InterviewerId, null)) cmd.Parameters.AddWithValue("@InterviewerId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@InterviewerId", interviewer.InterviewerId);
                
                  
                if (ReferenceEquals(interviewer.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", interviewer.Name);
                
                  
                if (ReferenceEquals(interviewer.createdTime, null) ||
                    (interviewer.createdTime == DateTime.MinValue)) cmd.Parameters.AddWithValue("@createdTime", DBNull.Value);
                  
                else cmd.Parameters.AddWithValue("@createdTime", interviewer.createdTime);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Interviewer interviewer)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = interviewer.InterviewerId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM [Interviewer] WHERE InterviewerId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(interviewer);
                else return this.Insert(interviewer);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllInterviewers<T>()
            where T : Interviewer, new()
        {
            return this.GetAllInterviewers<T>(String.Empty);
        }

        
        public List<T> GetAllInterviewers<T>(String whereClause)
            where T : Interviewer, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Interviewer]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T interviewer = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("InterviewerId");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          interviewer.InterviewerId = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          interviewer.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("createdTime");
                      if (!reader.IsDBNull(propertyIndex)) //DATETIME
                      {
                          
                          interviewer.createdTime = reader.GetDateTime(propertyIndex);
                      }
                   
                    results.Add(interviewer);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Interviewer
        /// </summary>
        /// <returns></returns>
        public int Update(Interviewer interviewer)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Interviewer] SET 
                                    [Name] = @Name, [createdTime] = @createdTime
                                    WHERE  [InterviewerId] = @InterviewerId", this.Schema);

                 //TEXT
                
                if (ReferenceEquals(interviewer.InterviewerId, null)) cmd.Parameters.AddWithValue("@InterviewerId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@InterviewerId", interviewer.InterviewerId);
                 //TEXT
                
                if (ReferenceEquals(interviewer.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", interviewer.Name);
                 //DATETIME
                
                if (ReferenceEquals(interviewer.createdTime, null) ||
                    (interviewer.createdTime == DateTime.MinValue)) cmd.Parameters.AddWithValue("@createdTime", DBNull.Value);
                  
                else cmd.Parameters.AddWithValue("@createdTime", interviewer.createdTime);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Interviewer
        /// </summary>
        /// <returns></returns>
        public int Delete(Interviewer interviewer)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Interviewer] 
                                    WHERE  [InterviewerId] = @InterviewerId", this.Schema);
                                    
                
                if (ReferenceEquals(interviewer.InterviewerId, null)) cmd.Parameters.AddWithValue("@InterviewerId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@InterviewerId", interviewer.InterviewerId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

          
  
        /// <summary>
        /// Returns a count of the numbers of rows affected by the insert
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
  
  
  
        public int Insert(Position position)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"INSERT INTO [{0}].[Position] (PositionId, RequiredExperience, Name, Description, createdTime)
                                    VALUES (@PositionId, @RequiredExperience, @Name, @Description, @createdTime)", this.Schema);

                
                  
                if (ReferenceEquals(position.PositionId, null)) cmd.Parameters.AddWithValue("@PositionId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PositionId", position.PositionId);
                
                  
                if (ReferenceEquals(position.RequiredExperience, null)) cmd.Parameters.AddWithValue("@RequiredExperience", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@RequiredExperience", position.RequiredExperience);
                
                  
                if (ReferenceEquals(position.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", position.Name);
                
                  
                if (ReferenceEquals(position.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", position.Description);
                
                  
                if (ReferenceEquals(position.createdTime, null) ||
                    (position.createdTime == DateTime.MinValue)) cmd.Parameters.AddWithValue("@createdTime", DBNull.Value);
                  
                else cmd.Parameters.AddWithValue("@createdTime", position.createdTime);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
          /// <summary>
        /// Returns a count of the numbers of rows affected by the Upsert.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="dataSource"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public int Upsert(Position position)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                
                // Check if this method exists, and call insert or udpate as appropriate
                
                
                var id = position.PositionId;
                cmd.CommandText = String.Format(@"SELECT CASE WHEN EXISTS (SELECT * FROM [Position] WHERE PositionId = '{0}') THEN 1 else 0 END", id);
                
                var rowExists = cmd.ExecuteScalar();

                if (rowExists.SafeToString() == "1") return this.Update(position);
                else return this.Insert(position);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<T> GetAllPositions<T>()
            where T : Position, new()
        {
            return this.GetAllPositions<T>(String.Empty);
        }

        
        public List<T> GetAllPositions<T>(String whereClause)
            where T : Position, new()
        {
            List<T> results = new List<T>();
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"SELECT * FROM [{0}].[Position]", this.Schema);
                if (!String.IsNullOrEmpty(whereClause)) 
                {
                    cmd.CommandText = String.Format("{0} WHERE {1}", cmd.CommandText, whereClause);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                int propertyIndex = -1;
                while (reader.Read())
                {
                    T position = new T();
                    
                    
                      propertyIndex = reader.GetOrdinal("PositionId");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          position.PositionId = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("RequiredExperience");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          position.RequiredExperience = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Name");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          position.Name = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("Description");
                      if (!reader.IsDBNull(propertyIndex)) //TEXT
                      {
                          
                          position.Description = reader.GetString(propertyIndex);
                      }
                   
                      propertyIndex = reader.GetOrdinal("createdTime");
                      if (!reader.IsDBNull(propertyIndex)) //DATETIME
                      {
                          
                          position.createdTime = reader.GetDateTime(propertyIndex);
                      }
                   
                    results.Add(position);
                }

                return results;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /// <summary>
        /// Updates the specified Position
        /// </summary>
        /// <returns></returns>
        public int Update(Position position)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"UPDATE [{0}].[Position] SET 
                                    [RequiredExperience] = @RequiredExperience, [Name] = @Name, [Description] = @Description, [createdTime] = @createdTime
                                    WHERE  [PositionId] = @PositionId", this.Schema);

                 //TEXT
                
                if (ReferenceEquals(position.PositionId, null)) cmd.Parameters.AddWithValue("@PositionId", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@PositionId", position.PositionId);
                 //TEXT
                
                if (ReferenceEquals(position.RequiredExperience, null)) cmd.Parameters.AddWithValue("@RequiredExperience", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@RequiredExperience", position.RequiredExperience);
                 //TEXT
                
                if (ReferenceEquals(position.Name, null)) cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Name", position.Name);
                 //TEXT
                
                if (ReferenceEquals(position.Description, null)) cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                    
                else cmd.Parameters.AddWithValue("@Description", position.Description);
                 //DATETIME
                
                if (ReferenceEquals(position.createdTime, null) ||
                    (position.createdTime == DateTime.MinValue)) cmd.Parameters.AddWithValue("@createdTime", DBNull.Value);
                  
                else cmd.Parameters.AddWithValue("@createdTime", position.createdTime);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }
        
                
        /// <summary>
        /// Deletes the specified Position
        /// </summary>
        /// <returns></returns>
        public int Delete(Position position)
        {
            SqlConnection conn = this.CreateSqlConnection();
            try
            {
                this.InitializeConnection(conn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = String.Format(@"DELETE FROM [{0}].[Position] 
                                    WHERE  [PositionId] = @PositionId", this.Schema);
                                    
                
                if (ReferenceEquals(position.PositionId, null)) cmd.Parameters.AddWithValue("@PositionId", DBNull.Value);
                else cmd.Parameters.AddWithValue("@PositionId", position.PositionId);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected;
            }
            finally
            {
                conn.Close();
            }
        }

                  
            
            

        public object LastIdentity { get; set; }
        public string ExecuteAsUser { get; set; }
        
        private SqlConnection CreateSqlConnection() 
        {
            if (String.IsNullOrEmpty(this.ConnectionString))
            {
                SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
                scsb.DataSource = this.DataSourceName;
                scsb.InitialCatalog = this.DBName;
                scsb.IntegratedSecurity = true;
                this.ConnectionString = scsb.ConnectionString;
            }
            
            SqlDataManager.LastConnectionString = this.ConnectionString;
            
            return new SqlConnection(this.ConnectionString);
        }
        
        
        private void InitializeConnection(SqlConnection conn)
        {
            conn.Open();
            if (!String.IsNullOrEmpty(this.ExecuteAsUser))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = String.Format("EXECUTE AS USER='{0}'", this.ExecuteAsUser);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

      