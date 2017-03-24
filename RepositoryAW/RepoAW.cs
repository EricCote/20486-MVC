using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAW
{
    public class RepoAW : IDisposable
    {
        ContextAW db = new ContextAW();

        public void Dispose()
        {
            db.Dispose();
        }

        public IQueryable<Category> GetAllCategories()
        {
            return db.Categories.Include("Products");
        }

        public IQueryable<Product> GetAllProducts()
        {
            return db.Products.Include("Category");
        }

        public IQueryable<Product> GetProductByCategory(string cat)
        {
            return (from p in db.Products.Include("Category")
                    where p.Category.Name==cat
                    select p);
        }

        public IQueryable<Product> GetProductByCategoryId(int catid)
        {
            return (from p in db.Products.Include("Category")
                    where p.Category.CategoryID == catid
                    select p);
        }


        public IQueryable<Product> GetProductByName(string name)
        {
            return (from p in db.Products.Include("Category")
                    where p.Name.StartsWith(name)
                    select p);
        }

        

    }
}
