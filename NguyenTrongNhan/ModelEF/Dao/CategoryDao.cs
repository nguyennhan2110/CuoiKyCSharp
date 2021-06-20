using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using ModelEF.Model;

namespace ModelEF.Dao
{
    public class CategoryDao
    {
        NguyenTrongNhanContext db = null;
        public CategoryDao()
        {
            db = new NguyenTrongNhanContext();
        }

        public long Insert(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return category.ID;
        }
        public List<Category> ListAll()
        {
            return db.Categories.Where(x => x.Status == true).ToList();
        }
        public ProductCategory ViewDetail(long id)
        {
            return db.ProductCategories.Find(id);
        }
    }
}
