using DataTableSample.IService;
using DataTableSample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketPurchaseController : ControllerBase
    {
        ITicketPurchaseService tp = null;

        public TicketPurchaseController(ITicketPurchaseService x)
        {
            tp = x;
        }

        // GET: api/<TicketPurchaseController>
        [HttpGet]
        public IEnumerable<TicketPurchase> GetT()
        {
            return tp.GetAll();
        }

        // GET api/<TicketPurchaseController>/5
        [HttpGet("{id}", Name = "Get")]
        public TicketPurchase Get(string id)
        {
            return tp.GetById(id);
        }

        // POST api/<TicketPurchaseController>
        [HttpPost]
        public void SaveOrUpdate([FromForm] TicketPurchase student)
        {
            try
            {
                if (student.SeatNumber != "0") tp.Save(student);
            }
            catch (Exception)
            {
                tp.Update(student);
            }
        }

        // PUT api/<TicketPurchaseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TicketPurchaseController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            return tp.Delete(id);
        }
    }
}

