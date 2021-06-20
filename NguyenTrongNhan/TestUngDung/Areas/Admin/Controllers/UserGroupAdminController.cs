using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung.Common;
using ModelEF.Model;
using ModelEF.Dao;
using PagedList;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class UserGroupAdminController : BaseController
    {
        // GET: Admin/UserGroupAdmin
        public ActionResult Index(string searchString, int page = 1, int pageSize = 5)
        {
            var dao = new UserGroupDao();
            var model = dao.ListAllPaging(searchString, page, pageSize);

            ViewBag.SearchString = searchString;
            return View(model);
        }
    }
}