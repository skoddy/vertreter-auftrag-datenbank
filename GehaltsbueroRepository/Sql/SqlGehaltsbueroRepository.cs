using Gehaltsbuero.Models;
using Microsoft.EntityFrameworkCore;

namespace Gehaltsbuero.Repository.Sql
{
    public class SqlGehaltsbueroRepository : IGehaltsbueroRepository
    {
        private readonly DbContextOptions<GehaltsbueroContext> _dbOptions;

        public SqlGehaltsbueroRepository(DbContextOptionsBuilder<GehaltsbueroContext>
            dbOptionsBuilder)
        {
            _dbOptions = dbOptionsBuilder.Options;
            using (var db = new GehaltsbueroContext(_dbOptions))
            {
                db.Database.EnsureCreated();
            }
        }


        public IVertreterRepository Vertreter => new SqlVertreterRepository(
            new GehaltsbueroContext(_dbOptions));
    }
}
