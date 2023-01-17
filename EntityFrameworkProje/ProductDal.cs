using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkProje.Entity;

namespace EntityFrameworkProje
{
    public class ProductDal
    {
        public List<Product> GetAllProducts()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Category> GetAllCategories()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Categories.ToList();
            }
        }

        public List<Product> ListByCategory(int Id)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Products.Where(p => p.CategoryID == Id).ToList();
            }
        }

        public List<Product> ListByProductName(string key)
        {
            using (NorthWindContext context=new NorthWindContext())
            {
                return context.Products.Where(p=>p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }
        }
    }
}
