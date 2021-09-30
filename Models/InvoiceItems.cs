using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flexpedia.Models
{
    public class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public int InvoiceId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
