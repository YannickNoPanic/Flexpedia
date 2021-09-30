using CsvHelper;
using Flexpedia.Interface;
using Flexpedia.Models;
using Flexpedia.Models.csv;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Flexpedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IInvoiceRepo InvoiceRepo;

        public HomeController(ILogger<HomeController> logger, IInvoiceRepo invoiceRepo)
        {
            _logger = logger;
            this.InvoiceRepo = invoiceRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> DownloadTransactions()
        {
            var data = await this.InvoiceRepo.GetAll();

            var csvData = data.Select(x => new Transaction { InvoiceID = x.InvoiceId, CompanyName = x.ClientName, InvoiceAmt = x.InvoiceAmount });
            
            var memory = new MemoryStream();
            using(   var writer = new StreamWriter(memory, leaveOpen: true))
            {
                writer.WriteLine($"Invoice ID,Company Name,Invoice Amount");
                foreach(var row in csvData)
                {
                    writer.WriteLine($"{row.InvoiceID},{row.CompanyName},{row.InvoiceAmt}");
                }
            }
            memory.Seek(0, SeekOrigin.Begin);
            var result = memory.ToArray();
            memory.Close();

            return File(result, "text/csv", "Transactions.csv");
        }

        public IActionResult DownloadCustomerReport()
        {
            throw new NotImplementedException();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
