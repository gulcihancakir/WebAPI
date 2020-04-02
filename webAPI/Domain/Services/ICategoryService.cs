using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAPI.Domain.Models;

namespace webAPI.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
