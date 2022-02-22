using DataTableSample.Context;
using DataTableSample.IService;
using DataTableSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample.Service
{
    public class TicketPurchaseService : ITicketPurchaseService
    {
        private readonly DatabaseContext _context;

        public TicketPurchaseService(DatabaseContext context)
        {
            _context = context;
        }

        public string Delete(string i)
        {
            var t = _context.TPDbSetObj.FirstOrDefault(x => x.SeatNumber == i);
            if (t != null)
            {
                _context.TPDbSetObj.Remove(t);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public TicketPurchase GetById(string i)
        {
            return _context.TPDbSetObj.SingleOrDefault(x => x.SeatNumber == i);
        }

        public List<TicketPurchase> GetAll()
        {
            return _context.TPDbSetObj.ToList();
        }

        public void Save(TicketPurchase o)
        {
            _context.TPDbSetObj.Add(o);
            _context.SaveChanges();
        }

        public void Update(TicketPurchase o)
        {
            _context.TPDbSetObj.Update(o);
            _context.SaveChanges();
        }
    }
}
