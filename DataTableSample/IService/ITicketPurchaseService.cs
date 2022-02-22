using DataTableSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample.IService
{
    public interface ITicketPurchaseService
    {
        List<TicketPurchase> GetAll();

        TicketPurchase GetById(string studentId);

        void Save(TicketPurchase oStudent);

        void Update(TicketPurchase oStudent);

        string Delete(string studentId);
    }
}
