using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAPI.Domain.Models;
using webAPI.Domain.Repositories;
using webAPI.Domain.Services;

namespace webAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
