using SQLite;

namespace Sample
{
    public interface IFileHelper
    {
        SQLiteConnection DbConnection();
    }
}
