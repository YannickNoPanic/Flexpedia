using Flexpedia.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flexpedia
{
    public class UnitOfWork : IUnitOfWork
    {
        public IInvoiceRepo Invoices { get; }
        public UnitOfWork(IInvoiceRepo invoiceRepo)
        {
            Invoices = invoiceRepo;
        }
    }
}
