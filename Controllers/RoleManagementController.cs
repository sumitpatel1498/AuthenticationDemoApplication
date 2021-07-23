using AuthenticationDemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationDemoApplication.Controllers
{
    public class RoleManagementController : Controller
    {
        DataContext DataCon = new DataContext();
        // GET: RoleManagement
        public ActionResult RoleManagement()
        {
            RoleManagementdata RoleMD = new RoleManagementdata();
            RoleMD.RoleManagement = new SelectList(DataCon.GetSelectListItem(), "Id", "Name");
            return View(RoleMD);
        }
    }
}