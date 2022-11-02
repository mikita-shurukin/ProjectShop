using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocs
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCatigories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Electric cars", desc = "Modern cars"},
                    new Category{categoryName = "Classic cars", desc = "Internal combustion engine vehicles" }
                };
            }
        }
    }
}
