using SQLite;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Sample.Droid.FileHelper))]

namespace Sample.Droid
{
    public class FileHelper : Sample.IFileHelper
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "db_sqlnet.db";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}