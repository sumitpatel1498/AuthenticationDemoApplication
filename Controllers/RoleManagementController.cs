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
        public ActionResult SelectRole()
        {
            RoleManagementdata RoleMD = new RoleManagementdata();
            RoleMD.RoleManagementDataList = new SelectList(DataCon.GetRoleManagementDataList(), "ID", "Name");
            return View(RoleMD);
        }
    }
}