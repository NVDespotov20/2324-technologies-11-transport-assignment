using Microsoft.EntityFrameworkCore;
using BikeRental.DAL.Data;

namespace BikeRental.BLL.Services
{
    public class DBContext
    {
        private static BikeRentalContext _dbContextInstance;
        private static readonly object LockObject = new object();

        private DBContext() { }

        public static BikeRentalContext GetContext()
        {
            if (_dbContextInstance == null)
            {
                lock (LockObject)
                {
                    if (_dbContextInstance == null)
                    {
                        _dbContextInstance = new BikeRentalContext();
                        _dbContextInstance.Database.Migrate();
                    }
                }
            }

            return _dbContextInstance;
        }
    }
}
