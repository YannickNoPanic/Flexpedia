using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flexpedia.Models.csv
{
    public class Transaction
    {
        public int InvoiceID { get; set; }
        public string CompanyName { get; set; }
        public decimal InvoiceAmt { get; set; }
    }
}
