using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAPI.Domain.Models;

namespace webAPI.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
