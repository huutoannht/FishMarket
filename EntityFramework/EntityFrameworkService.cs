using System;


namespace FishMarket.Entities
{

    public class EntityFrameworkService : IDataRepository, IDisposable
    {

        SakyMartEntities _connection;

        /// <summary>
        /// Database Context
        /// </summary>
        public SakyMartEntities dbConnection
        {
            get { return _connection; }
        }

        /// <summary>
        /// Commit Transaction
        /// </summary>
        /// <param name="closeSession"></param>
        public void CommitTransaction(Boolean closeSession)
        {
            dbConnection.SaveChanges();
        }

        /// <summary>
        /// Rollback Transaction
        /// </summary>
        /// <param name="closeSession"></param>
        public void RollbackTransaction(Boolean closeSession)
        {

        }

        public void Save(object entity) { }
        public void CreateSession() 
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CodeProjectDatabase, Configuration>()); 

            _connection = new SakyMartEntities(); 
        }
        public void BeginTransaction() { }

        public void CloseSession() { }

        /// <summary>
        /// Dispose of connection
        /// </summary>
        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
        }
    }
}
