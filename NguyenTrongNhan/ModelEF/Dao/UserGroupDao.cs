using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using System.Configuration;
using Common;
using ModelEF.Model;
namespace ModelEF.Dao
{
    public class UserGroupDao
    {
        NguyenTrongNhanContext db = null;
        public UserGroupDao()
        {
            db = new NguyenTrongNhanContext();
        }

        //Chèn thực thể
        public string Insert(UserGroup entity)
        {
            db.UserGroups.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        //Phân trang
        public IEnumerable<UserGroup> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<UserGroup> model = db.UserGroups;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString) || x.Name.Contains(searchString));
            }

            return model.OrderByDescending(x => x.Name).ToPagedList(page, pageSize);
        }

        //Xoá
        public bool Delete(string id)
        {
            try
            {
                var usergr = db.UserGroups.Find(id);
                db.UserGroups.Remove(usergr);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
