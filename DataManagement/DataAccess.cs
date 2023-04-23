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
        public static List<NoteModel> LoadNotes()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                List<NoteModel> notes = new List<NoteModel>();

                connection.Open();
                return connection.Query<NoteModel>("Select * From Notes").ToList();

            }
        }
        
        public static void RenameNote(int Id, string NewNoteName)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("update Notes set NoteName = @NewNoteName where Id = @Id", new { NewNoteName, Id });
            }
        }
        public static void DeleteNote(List<int> ids)
        {
            string sequence = string.Join(',', ids);
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute($"delete from Notes where Id in ({sequence})");
            }
        }
        public static void AddNote(NoteModel note) 
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Notes default values", note);
            }
        }
        public static void SaveNoteText(int Id, string Text, string EditTime)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("update Notes set Text = @Text, EditTime = @EditTime where Id = @Id", new {Text, EditTime, Id});
            }
        }
        private static string LoadConnectionString(string name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
