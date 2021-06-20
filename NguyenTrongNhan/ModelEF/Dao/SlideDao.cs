using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;

namespace ModelEF.Dao
{
    public class SlideDao
    {
        NguyenTrongNhanContext db = null;
        public SlideDao()
        {
            db = new NguyenTrongNhanContext();
        }
        public List<Slide> ListAll()
        {
            return db.Slides.Where(x => x.Status == true).OrderBy(y => y.DisplayOrder).ToList();
        }
    }
}
