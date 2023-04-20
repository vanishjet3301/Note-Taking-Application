using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class DataAccess
    {
        public static DataTable LoadNotes()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT NoteName, EditTime FROM Notes";

                using (IDataReader reader = connection.ExecuteReader(query))
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    return table;
                }
            }
        }
        public static string ReadNoteText(string NoteName)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var noteText = connection.QuerySingleOrDefault<string>("select Text from Notes where NoteName = @NoteName", new { NoteName = NoteName });
                return noteText ?? string.Empty;
            }
        }
        public static void RenameNote(string OldNoteName, string NewNoteName)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("update Notes set NoteName = @NewNoteName where NoteName = @OldNoteName", new { NewNoteName, OldNoteName });
            }
        }
        public static void DeleteNote(string NoteName)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("delete from Notes where NoteName = @NoteName", new { NoteName });
            }
        }
        public static void SaveNote(NoteModel note) 
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Notes (NoteName, EditTime, NoteText) values (@NoteName, @EditTime, @Text)", note);
            }
        }
        public static void EditNoteText(string NoteName, string Text, string EditTime)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("update Notes set Text = @Text, EditTime = @EditTime where NoteName = @NoteName", new {Text, EditTime, NoteName});
            }
        }
        private static string LoadConnectionString(string name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
