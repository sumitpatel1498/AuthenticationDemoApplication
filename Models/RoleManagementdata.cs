using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace AuthenticationDemoApplication.Models
{
    public class RoleManagementdata
    {
        public SelectList RoleManagement { get; set; }
    }
    [Table("dbo.AspNetRoles")]
    public class RoleManagement
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
}