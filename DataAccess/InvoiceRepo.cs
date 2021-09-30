using Dapper;
using Flexpedia.Interface;
using Flexpedia.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Flexpedia.DataAccess
{
    public class InvoiceRepo : IInvoiceRepo
    {
        private readonly IConfiguration configuration;
        public InvoiceRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<IReadOnlyList<Invoice>> GetAll()
        {
            var sql = @"SELECT * FROM Invoices";

            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Invoice>(sql);
                return result.ToList();
            }
            //make it read only
        }

        public async Task<Invoice> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM invoice WHERE Id = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Invoice>(sql, new { Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Invoice>> GetPaged(int pageNr, int size)
        {
            var offset = (pageNr - 1) * size;
            var sql = $"SELECT * FROM invoice OFFSET {offset} ROWS FETCH NEXT {size} ROWS ONLY";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Invoice>(sql);
                return result.ToList();
            }
        }
    }
}
