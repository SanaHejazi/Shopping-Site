using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Domain.Entities.Users;

namespace FinalProject.Application.Interface.Context
{
    public interface IDatabaseContext
    {
        
        DbSet<Users> Users{ get; set; }
        DbSet <Role> Roles { get; set; }
        DbSet <UserInRole> UserInRoles{ get; set; }
    }
}