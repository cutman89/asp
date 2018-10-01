using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPie.Data;
using ShopPie.Models;

namespace ShopPie.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> Categories => _context.Categories;
    }      
}
