using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flexpedia.Interface
{
    public interface IRepo<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<IReadOnlyList<T>> GetPaged(int pageNr, int size);
    }
}
