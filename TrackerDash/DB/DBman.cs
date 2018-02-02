using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using TrackerHelper.RedmineEntities;

namespace TrackerHelper.DB
{
    public delegate void MessageDelegate(string message);
    public class DBman
    {
        private static string _dbName = "TrackerHelper.db";

        public static void SetDbName(string dbName)
        {
            _dbName = dbName;
        }

        public static event MessageDelegate onError;


        // check if table exist
        public static bool Exist(string TableName)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = '" + TableName + "';";

                    try
                    {
                        return cmd.ExecuteScalar() != null ? true : false;
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }                
            }
        }

        #region ---------------------Create database/tables-------------------------
        public static bool CreateDatabase()
        {
            try
            {
                CreateIssuesTable();
                CreateTETable();
                CreateJournalsTable();
                CreateJournalDetailsTable();
                CreateUsersTable();
                CreateEmployeesPresetsTable();
                CreateProjectsPresetsTable();
                CreateStatusPresetsTable();
                CreatePresetsTable();
                return true;
            }
            catch (SQLiteException sqlex)
            {
                onError?.Invoke($"Error: {sqlex.Message}");
            }
            catch (Exception ex)
            {
                onError?.Invoke($"Error: {ex.Message}");
            }
            return false;
        }
        private static void CreateTETable()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS TimeEntries({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10});",
                                         "id INTEGER PRIMARY KEY",
                                         "ProjectId INTEGER",
                                         "ProjectName TEXT",
                                         "IssueId INTEGER",
                                         "UserId INTEGER",
                                         "UserName TEXT",
                                         "ActivityId INTEGER",
                                         "ActivityName TEXT",
                                         "Hours TEXT",
                                         "Comment TEXT",
                                         "SpentOn INTEGER");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }
        private static void CreateIssuesTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS Issues({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24});",
                                         "IssueId INTEGER PRIMARY KEY",
                                         "ProjectId INTEGER",
                                         "ProjectName TEXT",
                                         "TrackerId INTEGER",
                                         "TrackerName TEXT",
                                         "StatusId INTEGER",
                                         "StatusName TEXT",
                                         "PriorityId INTEGER",
                                         "PriorityName TEXT",
                                         "AuthorId INTEGER",
                                         "AuthorName TEXT",
                                         "AssignedToId INTEGER",
                                         "AssignedToName TEXT",
                                         "CategoryId INTEGER",
                                         "CategoryName TEXT",
                                         "Subject TEXT",
                                         "Description TEXT",
                                         "StartDate TEXT",
                                         "DueDate TEXT",
                                         "DoneRatio INTEGER",
                                         "IsPrivate INTEGER",
                                         "EstimatedHours TEXT",
                                         "CreatedOn TEXT",
                                         "UpdatedOn TEXT",
                                         "ClosedOn TEXT");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }
        private static void CreateJournalsTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS Journals({0},{1},{2},{3},{4},{5});",
                                         "Id INTEGER PRIMARY KEY",
                                         "UserId INTEGER",
                                         "UserName TEXT",
                                         "IssueId INTEGER",
                                         "Notes TEXT",
                                         "CreatedOn TEXT");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }
        private static void CreateJournalDetailsTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS JournalDetails({0},{1},{2},{3},{4},{5});",
                                         "id INTEGER PRIMARY KEY AUTOINCREMENT",
                                         "Property TEXT",
                                         "Name TEXT",
                                         "OldValue TEXT",
                                         "NewValue TEXT",
                                         "JournalId INTEGER");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }
        private static void CreateUsersTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format(@"CREATE TABLE IF NOT EXISTS Users({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15});",
                                         "Id INTEGER PRIMARY KEY",
                                         "Firstname TEXT",
                                         "Secondname TEXT",
                                         "Lastname TEXT",
                                         "EMail TEXT",
                                         "CompanyName TEXT",
                                         "City TEXT",
                                         "OfficeNo TEXT",
                                         "PhoneNo TEXT",
                                         "InternalPnoneNo TEXT",
                                         "Department TEXT",
                                         "Position TEXT",
                                         "RK7Assesment TEXT",
                                         "Language TEXT",
                                         "BaseAddress TEXT",
                                         "ApiKey TEXT");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }
        private static void CreatePresetsTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS Presets({0},{1},{2},{3});",
                                         "PresetID INTEGER PRIMARY KEY",
                                         "PresetName TEXT",
                                         "isActive INTEGER",
                                         "UpdateDays INTEGER");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }
        private static void CreateEmployeesPresetsTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS PresetsEmployees({0},{1},{2},{3});",
                                         "PresetId INTEGER",
                                         "EmplID INTEGER",
                                         "EmplName TEXT",
                                         "FOREIGN KEY(PresetID) REFERENCES Presets(PresetID) ON DELETE CASCADE");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }
        private static void CreateProjectsPresetsTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS PresetsProjects({0},{1},{2},{3});",
                                         "PresetId INTEGER ",
                                         "ProjID INTEGER ",
                                         "ProjName TEXT ",
                                         "FOREIGN KEY(PresetID) REFERENCES Presets(PresetID) ON DELETE CASCADE");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }
        private static void CreateStatusPresetsTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = string.Format("CREATE TABLE IF NOT EXISTS PresetsStatus({0},{1},{2},{3},{4});",
                                         "PresetID INTEGER",
                                         "StatusID INTEGER",
                                         "StatusName TEXT",
                                         "MaxHours INTEGER",
                                         "FOREIGN KEY(PresetID) REFERENCES Presets(PresetID) ON DELETE CASCADE");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }

        #endregion

        #region ------------------------- Modify methods ---------------------------
        public static void InsertPersons(List<Person> persons)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                // if connection established create sqlite command and begin transaction
                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        SQLiteTransaction transaction = conn.BeginTransaction();

                        cmd.CommandText = @"INSERT OR IGNORE INTO Users(Id, Firstname, Secondname, Lastname, EMail, CompanyName, City, OfficeNo, 
                                            PhoneNo, InternalPnoneNo, Department, Position, RK7Assesment, Language, BaseAddress, ApiKey) 
                                          VALUES (@Id, @Firstname, @Secondname, @Lastname, @EMail, @CompanyName, @City, @OfficeNo, 
                                            @PhoneNo, @InternalPnoneNo, @Department, @Position, @RK7Assesment, @Language, @BaseAddress, @ApiKey)";

                        // create command parameters
                        cmd.Parameters.AddWithValue("@Id", "");
                        cmd.Parameters.AddWithValue("@Firstname", "");
                        cmd.Parameters.AddWithValue("@Secondname", "");
                        cmd.Parameters.AddWithValue("@Lastname", "");
                        cmd.Parameters.AddWithValue("@EMail", "");
                        cmd.Parameters.AddWithValue("@CompanyName", "");
                        cmd.Parameters.AddWithValue("@City", "");
                        cmd.Parameters.AddWithValue("@OfficeNo", "");
                        cmd.Parameters.AddWithValue("@PhoneNo", "");
                        cmd.Parameters.AddWithValue("@InternalPnoneNo", "");
                        cmd.Parameters.AddWithValue("@Department", "");
                        cmd.Parameters.AddWithValue("@Position", "");
                        cmd.Parameters.AddWithValue("@RK7Assesment", "");
                        cmd.Parameters.AddWithValue("@Language", "");
                        cmd.Parameters.AddWithValue("@BaseAddress", "");
                        cmd.Parameters.AddWithValue("@ApiKey", "");

                        for (int i = 0; i < persons.Count; i++)
                        {
                            try
                            {   // cycle writing data in table
                                cmd.Parameters["@Id"].Value = persons[i].Id;
                                cmd.Parameters["@Firstname"].Value = persons[i].Firstname;
                                cmd.Parameters["@Secondname"].Value = persons[i].Secondname;
                                cmd.Parameters["@Lastname"].Value = persons[i].Lastname;
                                cmd.Parameters["@EMail"].Value = persons[i].EMail;
                                cmd.Parameters["@CompanyName"].Value = persons[i].CompanyName;
                                cmd.Parameters["@City"].Value = persons[i].City;
                                cmd.Parameters["@OfficeNo"].Value = persons[i].OfficeNo;
                                cmd.Parameters["@PhoneNo"].Value = persons[i].PhoneNo;
                                cmd.Parameters["@InternalPnoneNo"].Value = persons[i].InternalPhoneNo;
                                cmd.Parameters["@Department"].Value = persons[i].Department;
                                cmd.Parameters["@Position"].Value = persons[i].Position;
                                cmd.Parameters["@RK7Assesment"].Value = persons[i].RK7Assessment;
                                cmd.Parameters["@Language"].Value = persons[i].Language;
                                cmd.Parameters["@BaseAddress"].Value = persons[i].BaseAddress;
                                cmd.Parameters["@APiKey"].Value = persons[i].ApiKey;
                                cmd.ExecuteNonQuery();
                            }
                            catch (SQLiteException sqlex)
                            {
                                onError?.Invoke($"Error: {sqlex.Message}");
                            }
                            catch (Exception ex)
                            {
                                onError?.Invoke($"Error: {ex.Message}");
                            }
                        }
                        try
                        {
                            transaction.Commit();
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"Error: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Error: {ex.Message}");
                        }
                    }
                }

                conn.Close();
            }
        }
        public static void InsertPerson(Person person)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                // if connection established create sqlite command and begin transaction
                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        SQLiteTransaction transaction = conn.BeginTransaction();

                        cmd.CommandText = @"INSERT OR IGNORE INTO Users(Id, Firstname, Secondname, Lastname, EMail, CompanyName, City, OfficeNo, 
                                            PhoneNo, InternalPnoneNo, Department, Position, RK7Assesment, Language, BaseAddress, ApiKey) 
                                          VALUES (@Id, @Firstname, @Secondname, @Lastname, @EMail, @CompanyName, @City, @OfficeNo, 
                                            @PhoneNo, @InternalPnoneNo, @Department, @Position, @RK7Assesment, @Language, @BaseAddress, @ApiKey)";

                        // create command parameters
                        cmd.Parameters.AddWithValue("@Id", "");
                        cmd.Parameters.AddWithValue("@Firstname", "");
                        cmd.Parameters.AddWithValue("@Secondname", "");
                        cmd.Parameters.AddWithValue("@Lastname", "");
                        cmd.Parameters.AddWithValue("@EMail", "");
                        cmd.Parameters.AddWithValue("@CompanyName", "");
                        cmd.Parameters.AddWithValue("@City", "");
                        cmd.Parameters.AddWithValue("@OfficeNo", "");
                        cmd.Parameters.AddWithValue("@PhoneNo", "");
                        cmd.Parameters.AddWithValue("@InternalPnoneNo", "");
                        cmd.Parameters.AddWithValue("@Department", "");
                        cmd.Parameters.AddWithValue("@Position", "");
                        cmd.Parameters.AddWithValue("@RK7Assesment", "");
                        cmd.Parameters.AddWithValue("@Language", "");
                        cmd.Parameters.AddWithValue("@BaseAddress", "");
                        cmd.Parameters.AddWithValue("@ApiKey", "");


                        try
                        {   // cycle writing data in table
                            cmd.Parameters["@Id"].Value = person.Id;
                            cmd.Parameters["@Firstname"].Value = person.Firstname;
                            cmd.Parameters["@Secondname"].Value = person.Secondname;
                            cmd.Parameters["@Lastname"].Value = person.Lastname;
                            cmd.Parameters["@EMail"].Value = person.EMail;
                            cmd.Parameters["@CompanyName"].Value = person.CompanyName;
                            cmd.Parameters["@City"].Value = person.City;
                            cmd.Parameters["@OfficeNo"].Value = person.OfficeNo;
                            cmd.Parameters["@PhoneNo"].Value = person.PhoneNo;
                            cmd.Parameters["@InternalPnoneNo"].Value = person.InternalPhoneNo;
                            cmd.Parameters["@Department"].Value = person.Department;
                            cmd.Parameters["@Position"].Value = person.Position;
                            cmd.Parameters["@RK7Assesment"].Value = person.RK7Assessment;
                            cmd.Parameters["@Language"].Value = person.Language;
                            cmd.Parameters["@BaseAddress"].Value = person.BaseAddress;
                            cmd.Parameters["@APiKey"].Value = person.ApiKey;
                            cmd.ExecuteNonQuery();
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"Error: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Error: {ex.Message}");
                        }                        
                    }
                }

                conn.Close();
            }
        }
        // insert time entry to table
        public static void InsertTE(Time_entries TE)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {

                conn.Open();

                // if connection established create sqlite command and begin transaction
                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        SQLiteTransaction transaction = conn.BeginTransaction();

                        cmd.CommandText = "INSERT OR IGNORE INTO TimeEntries(id, ProjectId, ProjectName, IssueId, UserId, UserName, ActivityId, ActivityName, Hours, Comment, SpentOn) "
                                           + "VALUES (@id, @ProjectId, @ProjectName, @IssueId, @UserId, @UserName, @ActivityId, @ActivityName, @Hours, @Comment, @SpentOn)";
                        // create command parameters
                        cmd.Parameters.AddWithValue("@id", "");
                        cmd.Parameters.AddWithValue("@ProjectId", "");
                        cmd.Parameters.AddWithValue("@ProjectName", "");
                        cmd.Parameters.AddWithValue("@IssueId", "");
                        cmd.Parameters.AddWithValue("@UserId", "");
                        cmd.Parameters.AddWithValue("@UserName", "");
                        cmd.Parameters.AddWithValue("@ActivityId", "");
                        cmd.Parameters.AddWithValue("@ActivityName", "");
                        cmd.Parameters.AddWithValue("@Hours", "");
                        cmd.Parameters.AddWithValue("@Comment", "");
                        cmd.Parameters.AddWithValue("@SpentOn", "");

                        // cycle writing data in table
                        foreach (Time_entry teItem in TE.time_entry_list)
                        {
                            try
                            {
                                cmd.Parameters["@id"].Value = teItem.id;
                                cmd.Parameters["@ProjectId"].Value = teItem.project != null ? teItem.project.id : 0;
                                cmd.Parameters["@ProjectName"].Value = teItem.project.name != null ? teItem.project.name : "";
                                cmd.Parameters["@IssueId"].Value = teItem.issue != null ? teItem.issue.id : 0;
                                cmd.Parameters["@UserId"].Value = teItem.user != null ? teItem.user.id : 0;
                                cmd.Parameters["@UserName"].Value = teItem.user != null ? teItem.user.name : "";
                                cmd.Parameters["@ActivityId"].Value = teItem.activity != null ? teItem.activity.id : 0;
                                cmd.Parameters["@ActivityName"].Value = teItem.activity != null ? teItem.activity.name : "";
                                cmd.Parameters["@Hours"].Value = teItem.hours;
                                cmd.Parameters["@Comment"].Value = teItem.comments;
                                cmd.Parameters["@SpentOn"].Value = teItem.spent_on;
                                cmd.ExecuteNonQuery();
                            }
                            catch (SQLiteException sqlex)
                            {
                                onError?.Invoke($"Error: {sqlex.Message}");
                            }
                            catch (Exception ex)
                            {
                                onError?.Invoke($"Error: {ex.Message}");
                            }
                        }
                        transaction.Commit();
                    }
                }

                conn.Close();
            }
        }
        public static void InsertIssues(Issues issues)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {

                conn.Open();

                // if connection established create sqlite command and begin transaction
                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        SQLiteTransaction transaction = conn.BeginTransaction();

                        cmd.CommandText = "INSERT OR REPLACE INTO Issues(IssueId,ProjectId,ProjectName,TrackerId,TrackerName,StatusId,StatusName,PriorityId,PriorityName,AuthorId,AuthorName,AssignedToId,AssignedToName,CategoryId,CategoryName,Subject,Description,StartDate,DueDate,DoneRatio,IsPrivate,EstimatedHours,CreatedOn,UpdatedOn,ClosedOn) "
                                           + "VALUES (@IssueId, @ProjectId, @ProjectName, @TrackerId, @TrackerName, @StatusId, @StatusName, @PriorityId, @PriorityName, @AuthorId, @AuthorName, @AssignedToId, @AssignedToName, @CategoryId, @CategoryName, @Subject, @Description, @StartDate, @DueDate, @DoneRatio, @IsPrivate, @EstimatedHours, @CreatedOn, @UpdatedOn, @ClosedOn)";
                        // create command parameters
                        cmd.Parameters.AddWithValue("@IssueId", "");
                        cmd.Parameters.AddWithValue("@ProjectId", "");
                        cmd.Parameters.AddWithValue("@ProjectName", "");
                        cmd.Parameters.AddWithValue("@TrackerId", "");
                        cmd.Parameters.AddWithValue("@TrackerName", "");
                        cmd.Parameters.AddWithValue("@StatusId", "");
                        cmd.Parameters.AddWithValue("@StatusName", "");
                        cmd.Parameters.AddWithValue("@PriorityId", "");
                        cmd.Parameters.AddWithValue("@PriorityName", "");
                        cmd.Parameters.AddWithValue("@AuthorId", "");
                        cmd.Parameters.AddWithValue("@AuthorName", "");
                        cmd.Parameters.AddWithValue("@AssignedToId", "");
                        cmd.Parameters.AddWithValue("@AssignedToName", "");
                        cmd.Parameters.AddWithValue("@CategoryId", "");
                        cmd.Parameters.AddWithValue("@CategoryName", "");
                        cmd.Parameters.AddWithValue("@Subject", "");
                        cmd.Parameters.AddWithValue("@Description", "");
                        cmd.Parameters.AddWithValue("@StartDate", "");
                        cmd.Parameters.AddWithValue("@DueDate", "");
                        cmd.Parameters.AddWithValue("@DoneRatio", "");
                        cmd.Parameters.AddWithValue("@IsPrivate", "");
                        cmd.Parameters.AddWithValue("@EstimatedHours", "");
                        cmd.Parameters.AddWithValue("@CreatedOn", "");
                        cmd.Parameters.AddWithValue("@UpdatedOn", "");
                        cmd.Parameters.AddWithValue("@ClosedOn", "");

                        foreach (Issue issue in issues.issue)
                        {
                            try
                            {   // cycle writing data in table                            
                                if (issue == null)
                                    continue;
                                if (issue.JournalList.Count > 0)
                                {
                                    using (SQLiteCommand journalsCmd = conn.CreateCommand())
                                    {
                                        //       SQLiteTransaction journalsTransaction = conn.BeginTransaction();
                                        journalsCmd.CommandText = "INSERT OR IGNORE INTO Journals(Id, IssueId, UserId, UserName, CreatedOn, Notes) VALUES (@Id, @IssueId, @UserId, @UserName, @CreatedOn, @Notes)";
                                        // create command parameters
                                        journalsCmd.Parameters.AddWithValue("@Id", "");
                                        journalsCmd.Parameters.AddWithValue("@IssueId", "");
                                        journalsCmd.Parameters.AddWithValue("@UserId", "");
                                        journalsCmd.Parameters.AddWithValue("@UserName", "");
                                        journalsCmd.Parameters.AddWithValue("@CreatedOn", "");
                                        journalsCmd.Parameters.AddWithValue("@Notes", "");

                                        // cycle writing data in table
                                        foreach (IssueJournalItem JournalsItem in issue.JournalList)
                                        {
                                            if (JournalsItem.Details.Count > 0)
                                            {
                                                using (SQLiteCommand detailsCmd = conn.CreateCommand())
                                                {
                                                    detailsCmd.CommandText = "INSERT OR IGNORE INTO JournalDetails(JournalId, Property, Name, OldValue, NewValue) VALUES (@JournalId, @Property, @Name, @OldValue, @NewValue)";
                                                    // create command parameters
                                                    detailsCmd.Parameters.AddWithValue("@JournalId", "");
                                                    detailsCmd.Parameters.AddWithValue("@Property", "");
                                                    detailsCmd.Parameters.AddWithValue("@Name", "");
                                                    detailsCmd.Parameters.AddWithValue("@OldValue", "");
                                                    detailsCmd.Parameters.AddWithValue("@NewValue", "");

                                                    foreach (IssueJournalItem.Detail DetailItem in JournalsItem.Details)
                                                    {
                                                        detailsCmd.Parameters["@JournalId"].Value = JournalsItem.Id;
                                                        detailsCmd.Parameters["@Property"].Value = DetailItem.Property;
                                                        detailsCmd.Parameters["@Name"].Value = DetailItem.Name;
                                                        detailsCmd.Parameters["@OldValue"].Value = DetailItem.OldValue;
                                                        detailsCmd.Parameters["@NewValue"].Value = DetailItem.NewValue;
                                                        detailsCmd.ExecuteNonQuery();
                                                    }
                                                }
                                            }

                                            journalsCmd.Parameters["@id"].Value = JournalsItem.Id;
                                            journalsCmd.Parameters["@IssueId"].Value = issue.id;
                                            journalsCmd.Parameters["@UserId"].Value = JournalsItem.User.id;
                                            journalsCmd.Parameters["@UserName"].Value = JournalsItem.User.name;
                                            journalsCmd.Parameters["@Notes"].Value = JournalsItem.Notes;
                                            journalsCmd.Parameters["@CreatedOn"].Value = JournalsItem.CreatedOn;
                                            journalsCmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                                cmd.Parameters["@IssueId"].Value = issue.id;
                                cmd.Parameters["@ProjectId"].Value = issue.project.id;
                                cmd.Parameters["@ProjectName"].Value = issue.project.name;
                                cmd.Parameters["@TrackerId"].Value = issue.tracker.id;
                                cmd.Parameters["@TrackerName"].Value = issue.tracker.name;
                                cmd.Parameters["@StatusId"].Value = issue.status.id;
                                cmd.Parameters["@StatusName"].Value = issue.status.name;
                                cmd.Parameters["@PriorityId"].Value = issue.priority.id;
                                cmd.Parameters["@PriorityName"].Value = issue.priority.name;
                                cmd.Parameters["@AuthorId"].Value = issue.author.id;
                                cmd.Parameters["@AuthorName"].Value = issue.author.name;
                                cmd.Parameters["@AssignedToId"].Value = issue.assigned_to.id;
                                cmd.Parameters["@AssignedToName"].Value = issue.assigned_to.name;
                                cmd.Parameters["@CategoryId"].Value = issue.category.id;
                                cmd.Parameters["@CategoryName"].Value = issue.category.name;
                                cmd.Parameters["@Subject"].Value = issue.subject;
                                cmd.Parameters["@Description"].Value = issue.description;
                                cmd.Parameters["@StartDate"].Value = issue.startDate;
                                cmd.Parameters["@DueDate"].Value = issue.dueDate;
                                cmd.Parameters["@DoneRatio"].Value = issue.doneRatio;
                                cmd.Parameters["@IsPrivate"].Value = issue.IsPrivate == true ? 1 : 0;
                                cmd.Parameters["@EstimatedHours"].Value = issue.estimatedHours;
                                cmd.Parameters["@CreatedOn"].Value = issue.createdOn;
                                cmd.Parameters["@UpdatedOn"].Value = issue.updatedOn;
                                cmd.Parameters["@ClosedOn"].Value = issue.closedOn;
                                cmd.ExecuteNonQuery();

                            }
                            catch (SQLiteException sqlex)
                            {
                                onError?.Invoke($"Error: {sqlex.Message}");
                            }
                            catch (Exception ex)
                            {
                                onError?.Invoke($"Error: {ex.Message}");
                            }
                        }
                        try
                        {
                            transaction.Commit();
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"Error: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Error: {ex.Message}");
                        }

                    }
                }

                conn.Close();
            }
        }
        public static void InsertIssue(Issue issue)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                if (issue.JournalList.Count > 0)
                {
                    InsertJournals(issue);
                }

                conn.Open();

                // if connection established create sqlite command and begin transaction
                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        SQLiteTransaction transaction = conn.BeginTransaction();

                        cmd.CommandText = "INSERT OR REPLACE INTO Issues(IssueId,ProjectId,ProjectName,TrackerId,TrackerName,StatusId,StatusName,PriorityId,PriorityName,AuthorId,AuthorName,AssignedToId,AssignedToName,CategoryId,CategoryName,Subject,Description,StartDate,DueDate,DoneRatio,IsPrivate,EstimatedHours,CreatedOn,UpdatedOn,ClosedOn) "
                                           + "VALUES (@IssueId, @ProjectId, @ProjectName, @TrackerId, @TrackerName, @StatusId, @StatusName, @PriorityId, @PriorityName, @AuthorId, @AuthorName, @AssignedToId, @AssignedToName, @CategoryId, @CategoryName, @Subject, @Description, @StartDate, @DueDate, @DoneRatio, @IsPrivate, @EstimatedHours, @CreatedOn, @UpdatedOn, @ClosedOn)";
                        // create command parameters
                        cmd.Parameters.AddWithValue("@IssueId", "");
                        cmd.Parameters.AddWithValue("@ProjectId", "");
                        cmd.Parameters.AddWithValue("@ProjectName", "");
                        cmd.Parameters.AddWithValue("@TrackerId", "");
                        cmd.Parameters.AddWithValue("@TrackerName", "");
                        cmd.Parameters.AddWithValue("@StatusId", "");
                        cmd.Parameters.AddWithValue("@StatusName", "");
                        cmd.Parameters.AddWithValue("@PriorityId", "");
                        cmd.Parameters.AddWithValue("@PriorityName", "");
                        cmd.Parameters.AddWithValue("@AuthorId", "");
                        cmd.Parameters.AddWithValue("@AuthorName", "");
                        cmd.Parameters.AddWithValue("@AssignedToId", "");
                        cmd.Parameters.AddWithValue("@AssignedToName", "");
                        cmd.Parameters.AddWithValue("@CategoryId", "");
                        cmd.Parameters.AddWithValue("@CategoryName", "");
                        cmd.Parameters.AddWithValue("@Subject", "");
                        cmd.Parameters.AddWithValue("@Description", "");
                        cmd.Parameters.AddWithValue("@StartDate", "");
                        cmd.Parameters.AddWithValue("@DueDate", "");
                        cmd.Parameters.AddWithValue("@DoneRatio", "");
                        cmd.Parameters.AddWithValue("@IsPrivate", "");
                        cmd.Parameters.AddWithValue("@EstimatedHours", "");
                        cmd.Parameters.AddWithValue("@CreatedOn", "");
                        cmd.Parameters.AddWithValue("@UpdatedOn", "");
                        cmd.Parameters.AddWithValue("@ClosedOn", "");

                        try
                        {   // cycle writing data in table
                            cmd.Parameters["@IssueId"].Value = issue.id;
                            cmd.Parameters["@ProjectId"].Value = issue.project.id;
                            cmd.Parameters["@ProjectName"].Value = issue.project.name;
                            cmd.Parameters["@TrackerId"].Value = issue.tracker.id;
                            cmd.Parameters["@TrackerName"].Value = issue.tracker.name;
                            cmd.Parameters["@StatusId"].Value = issue.status.id;
                            cmd.Parameters["@StatusName"].Value = issue.status.name;
                            cmd.Parameters["@PriorityId"].Value = issue.priority.id;
                            cmd.Parameters["@PriorityName"].Value = issue.priority.name;
                            cmd.Parameters["@AuthorId"].Value = issue.author.id;
                            cmd.Parameters["@AuthorName"].Value = issue.author.name;
                            cmd.Parameters["@AssignedToId"].Value = issue.assigned_to.id;
                            cmd.Parameters["@AssignedToName"].Value = issue.assigned_to.name;
                            cmd.Parameters["@CategoryId"].Value = issue.category.id;
                            cmd.Parameters["@CategoryName"].Value = issue.category.name;
                            cmd.Parameters["@Subject"].Value = issue.subject;
                            cmd.Parameters["@Description"].Value = issue.description;
                            cmd.Parameters["@StartDate"].Value = issue.startDate;
                            cmd.Parameters["@DueDate"].Value = issue.dueDate;
                            cmd.Parameters["@DoneRatio"].Value = issue.doneRatio;
                            cmd.Parameters["@IsPrivate"].Value = issue.IsPrivate == true ? 1 : 0;
                            cmd.Parameters["@EstimatedHours"].Value = issue.estimatedHours;
                            cmd.Parameters["@CreatedOn"].Value = issue.createdOn;
                            cmd.Parameters["@UpdatedOn"].Value = issue.updatedOn;
                            cmd.Parameters["@ClosedOn"].Value = issue.closedOn;
                            cmd.ExecuteNonQuery();
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"Error: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Error: {ex.Message}");
                        }
                        transaction.Commit();
                    }
                }

                conn.Close();
            }
        }
        private static void InsertJournals(Issue issue)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                if (issue.JournalList.Count > 0)
                {
                    InsertDetails(issue);
                }

                conn.Open();

                // if connection established create sqlite command and begin transaction
                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        SQLiteTransaction transaction = conn.BeginTransaction();

                        cmd.CommandText = "INSERT OR IGNORE INTO Journals(Id, IssueId, UserId, UserName, CreatedOn, Notes) "
                                           + "VALUES (@Id, @IssueId, @UserId, @UserName, @CreatedOn, @Notes)";
                        // create command parameters
                        cmd.Parameters.AddWithValue("@Id", "");
                        cmd.Parameters.AddWithValue("@IssueId", "");
                        cmd.Parameters.AddWithValue("@UserId", "");
                        cmd.Parameters.AddWithValue("@UserName", "");
                        cmd.Parameters.AddWithValue("@CreatedOn", "");
                        cmd.Parameters.AddWithValue("@Notes", "");
                        try
                        {   // cycle writing data in table
                            foreach (IssueJournalItem Item in issue.JournalList)
                            {
                                cmd.Parameters["@id"].Value = Item.Id;
                                cmd.Parameters["@IssueId"].Value = issue.id;
                                cmd.Parameters["@UserId"].Value = Item.User.id;
                                cmd.Parameters["@UserName"].Value = Item.User.name;
                                cmd.Parameters["@Notes"].Value = Item.Notes;
                                cmd.Parameters["@CreatedOn"].Value = Item.CreatedOn;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"Error: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Error: {ex.Message}");
                        }
                        transaction.Commit();
                    }
                }

                conn.Close();
            }
        }
        private static void InsertDetails(Issue issue)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    using (SQLiteTransaction transaction = conn.BeginTransaction())
                    {
                        cmd.CommandText = "INSERT OR IGNORE INTO JournalDetails(JournalId, Property, Name, OldValue, NewValue) "
                                           + "VALUES (@JournalId, @Property, @Name, @OldValue, @NewValue)";
                        // create command parameters
                        cmd.Parameters.AddWithValue("@JournalId", "");
                        cmd.Parameters.AddWithValue("@Property", "");
                        cmd.Parameters.AddWithValue("@Name", "");
                        cmd.Parameters.AddWithValue("@OldValue", "");
                        cmd.Parameters.AddWithValue("@NewValue", "");

                        try
                        {   // cycle writing data in table
                            foreach (IssueJournalItem JournalItem in issue.JournalList)
                            {
                                foreach (IssueJournalItem.Detail DetailItem in JournalItem.Details)
                                {
                                    cmd.Parameters["@JournalId"].Value = JournalItem.Id;
                                    cmd.Parameters["@Property"].Value = DetailItem.Property;
                                    cmd.Parameters["@Name"].Value = DetailItem.Name;
                                    cmd.Parameters["@OldValue"].Value = DetailItem.OldValue;
                                    cmd.Parameters["@NewValue"].Value = DetailItem.NewValue;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"Error: {sqlex.Message}");
                        }
                        transaction.Commit();
                    }
                }

                conn.Close();
            }
        }
        public static void InsertPreset(DashboardPreset preset)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        SQLiteTransaction transaction = conn.BeginTransaction();

                        cmd.CommandText = @"INSERT OR REPLACE INTO Presets(PresetId, PresetName, isActive, UpdateDays) 
                                            VALUES (@PresetId, @PresetName, @isActive, @UpdateDays)";
                        // create command parameters
                        cmd.Parameters.AddWithValue("@PresetId", "");
                        cmd.Parameters.AddWithValue("@PresetName", "");
                        cmd.Parameters.AddWithValue("@isActive", "");
                        cmd.Parameters.AddWithValue("@UpdateDays", "");
                        try
                        {
                            if (preset.Employees.Count > 0)
                            {
                                using (SQLiteCommand emplCmd = conn.CreateCommand())
                                {
                                    emplCmd.CommandText = @"INSERT OR REPLACE INTO PresetsEmployees(PresetID, EmplId, EmplName) 
                                                             VALUES (@PresetID, @EmplId, @EmplName)";
                                    // create command parameters
                                    emplCmd.Parameters.AddWithValue("@PresetID", "");
                                    emplCmd.Parameters.AddWithValue("@EmplId", "");
                                    emplCmd.Parameters.AddWithValue("@EmplName", "");
                                    foreach (IdName idname in preset.Employees)
                                    {
                                        emplCmd.Parameters["@PresetID"].Value = preset.ID;
                                        emplCmd.Parameters["@EmplId"].Value = idname.id;
                                        emplCmd.Parameters["@EmplName"].Value = idname.name;
                                        emplCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                            if (preset.Projects.Count > 0)
                            {
                                using (SQLiteCommand projCmd = conn.CreateCommand())
                                {
                                    projCmd.CommandText = @"INSERT OR REPLACE INTO PresetsProjects(PresetID, ProjId, ProjName) 
                                                            VALUES (@PresetID, @ProjId, @ProjName)";
                                    // create command parameters
                                    projCmd.Parameters.AddWithValue("@PresetID", "");
                                    projCmd.Parameters.AddWithValue("@ProjId", "");
                                    projCmd.Parameters.AddWithValue("@ProjName", "");
                                    foreach (IdName idname in preset.Projects)
                                    {
                                        projCmd.Parameters["@PresetID"].Value = preset.ID;
                                        projCmd.Parameters["@ProjId"].Value = idname.id;
                                        projCmd.Parameters["@ProjName"].Value = idname.name;
                                        projCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                            if (preset.Statuses.Count > 0)
                            {
                                using (SQLiteCommand statusCmd = conn.CreateCommand())
                                {
                                    statusCmd.CommandText = @"INSERT OR REPLACE INTO PresetsStatus(PresetID, StatusId, StatusName, MaxHours) 
                                                             VALUES (@PresetID, @StatusId, @StatusName, @MaxHours)";
                                    // create command parameters
                                    statusCmd.Parameters.AddWithValue("@PresetID", "");
                                    statusCmd.Parameters.AddWithValue("@StatusId", "");
                                    statusCmd.Parameters.AddWithValue("@StatusName", "");
                                    statusCmd.Parameters.AddWithValue("@MaxHours", "");
                                    foreach (Status status in preset.Statuses)
                                    {
                                        statusCmd.Parameters["@PresetID"].Value = preset.ID;
                                        statusCmd.Parameters["@StatusID"].Value = status.ID;
                                        statusCmd.Parameters["@StatusName"].Value = status.Name;
                                        statusCmd.Parameters["@MaxHours"].Value = status.MaxHours;
                                        statusCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            cmd.Parameters["@PresetID"].Value = preset.ID;
                            cmd.Parameters["@PresetName"].Value = preset.Name;
                            cmd.Parameters["@isActive"].Value = preset.isActive == true ? 1 : 0;
                            cmd.Parameters["@UpdateDays"].Value = preset.UpdateDays;

                            cmd.ExecuteNonQuery();
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"Error: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Error: {ex.Message}");
                        }
                        transaction.Commit();
                    }
                }

                conn.Close();
            }
        }
        public static void DeletePreset(int PresetId)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"PRAGMA foreign_keys = ""1"";";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"DELETE FROM Presets WHERE PresetId = {PresetId.ToString()}";

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"Error: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Error: {ex.Message}");
                    }
                }

                conn.Close();
            }
        }

        #endregion

        #region ------------------------ get/calc methods---------------------------

        public static void GetIssue(Issue issue)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;");

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from Issues where IssueId = @IssueId";
                cmd.Parameters.AddWithValue("@IssueId", issue.id);
                try
                {
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        issue.project.id = int.Parse(r["ProjectId"].ToString());
                        issue.project.name = r["ProjectName"].ToString();
                        issue.tracker.id = int.Parse(r["TrackerId"].ToString());
                        issue.tracker.name = r["TrackerName"].ToString();
                        issue.status.id = int.Parse(r["StatusId"].ToString());
                        issue.status.name = r["StatusName"].ToString();
                        issue.priority.id = int.Parse(r["PriorityId"].ToString());
                        issue.priority.name = r["PriorityName"].ToString();
                        issue.author.id = int.Parse(r["AuthorId"].ToString());
                        issue.author.name = r["AuthorName"].ToString();
                        issue.assigned_to.id = int.Parse(r["AssignedToId"].ToString());
                        issue.assigned_to.name = r["AssignedToName"].ToString();
                        issue.category.id = int.Parse(r["CategoryId"].ToString());
                        issue.category.name = r["CategoryName"].ToString();
                        issue.subject = r["Subject"].ToString();
                        issue.description = r["Description"].ToString();
                        issue.startDate = r["StartDate"].ToString();
                        issue.dueDate = r["DueDate"].ToString();
                        issue.doneRatio = r["DoneRatio"].ToString();
                        issue.IsPrivate = int.Parse(r["IsPrivate"].ToString()) == 0 ? false : true;
                        issue.estimatedHours = r["EstimatedHours"].ToString();
                        issue.createdOn = r["CreatedOn"].ToString();
                        issue.updatedOn = r["UpdatedOn"].ToString();
                        issue.closedOn = r["ClosedOn"].ToString();
                    }
                    r.Close();
                }
                catch (SQLiteException sqlex)
                {
                    onError?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }

            conn.Close();
        }
        public enum IssueType
        {
            Created,
            Closed
        }
        public enum GroupFormat
        {
            Day,
            Month,
            Year,
        }
        public static DataTable OpenQuery(string sql)
        {
            DataTable dt = null;
            if (sql.Length > 0)
            {
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
                {
                    conn.Open();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, conn);
                    DataSet dataSet = new DataSet();
                    dataSet.Reset();
                    dataAdapter.Fill(dataSet);
                    dt = dataSet.Tables[0];
                    conn.Close();
                }
            }
            return dt;
        }
        public static void OpenQuery2(string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException sqlex)
                    {
                        onError?.Invoke($"SQLiteException: {sqlex.Message}");
                    }
                    catch (Exception ex)
                    {
                        onError?.Invoke($"Exception: {ex.Message}");
                    }
                }
                conn.Close();
            }
        }
        public static void GetOpenedIssues(Issues issues, int NumOfDays)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM Issues WHERE UpdatedOn > '{DateTime.Now.AddDays(-NumOfDays).ToString("yyyy-MM-dd HH:mm:ss.fff")}' ORDER BY IssueID";
                        try
                        {
                            SQLiteDataReader r = cmd.ExecuteReader();
                            while (r.Read())
                            {
                                Issue issue = new Issue();
                                issue.id = r["IssueId"].ToString();
                                issue.project.id = int.Parse(r["ProjectId"].ToString());
                                issue.project.name = r["ProjectName"].ToString();
                                issue.tracker.id = int.Parse(r["TrackerId"].ToString());
                                issue.tracker.name = r["TrackerName"].ToString();
                                issue.status.id = int.Parse(r["StatusId"].ToString());
                                issue.status.name = r["StatusName"].ToString();
                                issue.priority.id = int.Parse(r["PriorityId"].ToString());
                                issue.priority.name = r["PriorityName"].ToString();
                                issue.author.id = int.Parse(r["AuthorId"].ToString());
                                issue.author.name = r["AuthorName"].ToString();
                                issue.assigned_to.id = int.Parse(r["AssignedToId"].ToString());
                                issue.assigned_to.name = r["AssignedToName"].ToString();
                                issue.category.id = int.Parse(r["CategoryId"].ToString());
                                issue.category.name = r["CategoryName"].ToString();
                                issue.subject = r["Subject"].ToString();
                                issue.description = r["Description"].ToString();
                                issue.startDate = r["StartDate"].ToString();
                                issue.dueDate = r["DueDate"].ToString();
                                issue.doneRatio = r["DoneRatio"].ToString();
                                issue.IsPrivate = int.Parse(r["IsPrivate"].ToString()) == 0 ? false : true;
                                issue.estimatedHours = r["EstimatedHours"].ToString();
                                issue.createdOn = r["CreatedOn"].ToString();
                                issue.updatedOn = r["UpdatedOn"].ToString();
                                issue.closedOn = r["ClosedOn"].ToString();
                                issues.issue.Add(issue);
                            }
                            r.Close();
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"SQLiteException: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Exception: {ex.Message}");
                        }
                    }
                }

                conn.Close();
            }
        }
        public static void GetIssuesListByUserId(string UserId, Issues issues)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;");

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Issues WHERE AssignedToId = @UserId and StatusId not in (3,5,6,19,26,27,29,30) ORDER BY IssueID";
                cmd.Parameters.AddWithValue("@UserId", UserId);
                try
                {
                    SQLiteDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Issue issue = new Issue();
                        issue.project.id = int.Parse(r["ProjectId"].ToString());
                        issue.project.name = r["ProjectName"].ToString();
                        issue.tracker.id = int.Parse(r["TrackerId"].ToString());
                        issue.tracker.name = r["TrackerName"].ToString();
                        issue.status.id = int.Parse(r["StatusId"].ToString());
                        issue.status.name = r["StatusName"].ToString();
                        issue.priority.id = int.Parse(r["PriorityId"].ToString());
                        issue.priority.name = r["PriorityName"].ToString();
                        issue.author.id = int.Parse(r["AuthorId"].ToString());
                        issue.author.name = r["AuthorName"].ToString();
                        issue.assigned_to.id = int.Parse(r["AssignedToId"].ToString());
                        issue.assigned_to.name = r["AssignedToName"].ToString();
                        issue.category.id = int.Parse(r["CategoryId"].ToString());
                        issue.category.name = r["CategoryName"].ToString();
                        issue.subject = r["Subject"].ToString();
                        issue.description = r["Description"].ToString();
                        issue.startDate = r["StartDate"].ToString();
                        issue.dueDate = r["DueDate"].ToString();
                        issue.doneRatio = r["DoneRatio"].ToString();
                        issue.IsPrivate = int.Parse(r["IsPrivate"].ToString()) == 0 ? false : true;
                        issue.estimatedHours = r["EstimatedHours"].ToString();
                        issue.createdOn = r["CreatedOn"].ToString();
                        issue.updatedOn = r["UpdatedOn"].ToString();
                        issue.closedOn = r["ClosedOn"].ToString();
                        issues.issue.Add(issue);
                    }
                    r.Close();
                }
                catch (SQLiteException sqlex)
                {
                    onError?.Invoke($"Error: {sqlex.Message}");
                }
                cmd.Dispose();
                conn.Dispose();
            }

            conn.Close();
        }
        public static List<DashboardPreset> GetPresetList()
        {
            List<DashboardPreset> presetList = new List<DashboardPreset>();
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM Presets p";
                        try
                        {
                            SQLiteDataReader r = cmd.ExecuteReader();
                            while (r.Read())
                            {
                                DashboardPreset preset = new DashboardPreset();
                                preset.ID = Convert.ToInt32(r["PresetID"].ToString());
                                preset.Name = r["PresetName"].ToString();
                                preset.isActive = Convert.ToInt32(r["isActive"].ToString()) == 0 ? false : true;
                                preset.UpdateDays = Convert.ToInt32(r["UpdateDays"].ToString());
                                presetList.Add(preset);
                            }
                            r.Close();
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"SQLiteException: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Exception: {ex.Message}");
                        }
                    }
                }

                conn.Close();
            }
            for(int i = 0; i< presetList.Count;i++)
            {
                presetList[i].Projects = GetPresetProjects(presetList[i].ID);
                presetList[i].Employees = GetPresetEmployees(presetList[i].ID);
                presetList[i].Statuses = GetPresetStatuses(presetList[i].ID);
            }

            return presetList;
        }
        public static DashboardPreset GetActivePreset()
        {
            DashboardPreset preset = null;
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM Presets WHERE isActive = 1";
                        try
                        {
                            SQLiteDataReader r = cmd.ExecuteReader();
                            while (r.Read())
                            {
                                preset = new DashboardPreset();
                                preset.ID = Convert.ToInt32(r["PresetID"].ToString());
                                preset.Name = r["PresetName"].ToString();
                                preset.isActive = Convert.ToInt32(r["isActive"].ToString()) == 0 ? false : true;
                                preset.UpdateDays = Convert.ToInt32(r["UpdateDays"].ToString());
                            }
                            r.Close();
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"SQLiteException: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Exception: {ex.Message}");
                        }
                    }
                }

                conn.Close();
            }
            if (preset != null)
            {
                preset.Projects = GetPresetProjects(preset.ID);
                preset.Employees = GetPresetEmployees(preset.ID);
                preset.Statuses = GetPresetStatuses(preset.ID);
            }            
            return preset;
        }
        private static List<IdName> GetPresetProjects(int PresetId)
        {
            List<IdName> projectslist = new List<IdName>();

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM PresetsProjects WHERE PresetId = {PresetId}";
                        try
                        {
                            using (SQLiteDataReader r = cmd.ExecuteReader())
                            {
                                while (r.Read())
                                {
                                    IdName project = new IdName();
                                    project.id = int.Parse(r["ProjId"].ToString());
                                    project.name = r["ProjName"].ToString();

                                    projectslist.Add(project);
                                }
                            }
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"SQLiteException: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Exception: {ex.Message}");
                        }
                    }
                }

                conn.Close();
            }

            return projectslist;
        }
        private static List<IdName> GetPresetEmployees(int PresetId)
        {
            List<IdName> employeesList = new List<IdName>();

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM PresetsEmployees WHERE PresetId = {PresetId}";
                        try
                        {
                            using (SQLiteDataReader r = cmd.ExecuteReader())
                            {
                                while (r.Read())
                                {
                                    IdName employee = new IdName();
                                    employee.id = int.Parse(r["EmplId"].ToString());
                                    employee.name = r["EmplName"].ToString();

                                    employeesList.Add(employee);
                                }
                            }
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"SQLiteException: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Exception: {ex.Message}");
                        }
                    }
                }

                conn.Close();
            }

            return employeesList;
        }
        private static List<Status> GetPresetStatuses(int PresetId)
        {
            List<Status> StatusesList = new List<Status>();

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={_dbName}; Version=3;"))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM PresetsStatus WHERE PresetId = {PresetId}";
                        try
                        {
                            using (SQLiteDataReader r = cmd.ExecuteReader())
                            {
                                while (r.Read())
                                {
                                    Status status = new Status();
                                    status.ID = int.Parse(r["StatusId"].ToString());
                                    status.Name = r["StatusName"].ToString();
                                    status.MaxHours = int.Parse(r["MaxHours"].ToString());
                                    StatusesList.Add(status);
                                }
                            }
                        }
                        catch (SQLiteException sqlex)
                        {
                            onError?.Invoke($"SQLiteException: {sqlex.Message}");
                        }
                        catch (Exception ex)
                        {
                            onError?.Invoke($"Exception: {ex.Message}");
                        }
                    }
                }

                conn.Close();
            }

            return StatusesList;
        }
       // public static
        #endregion
    }
}
