using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAPI.Domain.Models;

namespace webAPI.Domain.Repositories
{

    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
