using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Domain.Entities.Users;

namespace FinalProjec.Application.Services.Queries.GetUsers
{
    public interface IGetUserService
    {
        ResulGetUsertDto Execute(RequestClassDto request);
    }
    




}