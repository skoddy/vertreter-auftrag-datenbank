using Gehaltsbuero.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gehaltsbuero.Repository.Sql
{
    public class SqlAuftragRepository : IAuftragRepository
    {
        private readonly GehaltsbueroContext _db;

        public SqlAuftragRepository(GehaltsbueroContext db)
        {
            _db = db;
        }

        public void Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Auftrag> Get()
        {
            throw new NotImplementedException();
        }

        public Auftrag Get(Guid guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Auftrag> Get(string search)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Auftrag> GetForVertreter(Guid guid)
        {
            return _db.Auftrag
                .Where(auftrag => auftrag.VertreterId == guid)
                .Include(auftrag => auftrag.Posten)
                .ThenInclude(posten => posten.Produkt)
                .AsNoTracking()
                .ToList();
        }

        public Auftrag Upsert(Auftrag auftrag)
        {
            throw new NotImplementedException();
        }
    }
}
