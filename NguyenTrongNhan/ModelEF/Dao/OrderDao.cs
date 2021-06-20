using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;

namespace ModelEF.Dao
{
    public class OrderDao
    {
        NguyenTrongNhanContext db = null;
        public OrderDao()
        {
            db = new NguyenTrongNhanContext();
        }
        public long Insert(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.ID;
        }
    }
}
