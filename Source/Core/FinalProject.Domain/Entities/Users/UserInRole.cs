using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Domain.Entities.Users
{
    public class UserInRole
    {
        public long UserInRoleId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual Users Users { get; set; }
        public long UserId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public virtual Role Roles { get; set; }
        public long RoleId { get; set; }
    }
}
 