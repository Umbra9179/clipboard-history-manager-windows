using Microsoft.Data.Sqlite;

namespace clipboard-history-manager-windows.Services.Migrations
{
    public interface ISqliteMigration
    {
        /// <summary>
        /// Version of current migration
        /// </summary>
        int Version { get; }

        /// <summary>
        /// Migrate the database 'up'
        /// </summary>
        /// <param name="connection">Connection for Sqlite database</param>
        void Up(SqliteConnection connection);

        /// <summary>
        /// Migrate the database 'down'
        /// </summary>
        /// <param name="connection">Connection for Sqlite database</param>
        void Down(SqliteConnection connection);
    }
}
