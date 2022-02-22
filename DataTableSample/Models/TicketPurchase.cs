using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample.Models
{
    public class TicketPurchase
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SeatNumber { get; set; } = "0";
   
        public string CustomerName { get; set; }
    
        public string CustomerAddress { get; set; }
       
        public int TicketPrice { get; set; }
       
        public string BusNumber { get; set; }
     
        public DateTime OnboardingTime { get; set; }

    }
}
