using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Flexpedia.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string ClientName { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal InvoiceAmountPlusVat { get; set; }
        public decimal VatRate { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
    }
}
