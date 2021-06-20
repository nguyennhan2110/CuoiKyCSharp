using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;

namespace ModelEF.Dao
{
    public class MenuDao
    {
        NguyenTrongNhanContext db = null;
        public MenuDao()
        {
            db = new NguyenTrongNhanContext();
        }
        public List<Menu> ListByGroupID(int groupID)
        {
            return db.Menus.Where(x => x.TypeID == groupID && x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }
    }
}
