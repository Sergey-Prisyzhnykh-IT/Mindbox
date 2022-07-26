using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLProductsCategory
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Category { get; set; } = new();
    }
}
