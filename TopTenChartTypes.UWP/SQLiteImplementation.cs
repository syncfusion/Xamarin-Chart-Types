using Sample.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteImplementation))]
namespace Sample.UWP
{
    public class SQLiteImplementation : IFileHelper
    {
        SQLite.SQLiteConnection IFileHelper.DbConnection()
        {
            var dbName = "db_sqlnet.db";
            var path = Path.Combine(@"C:\db", dbName);
            return new SQLite.SQLiteConnection(path);
        }
    }
}
