using ShopPie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPie.Services
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
