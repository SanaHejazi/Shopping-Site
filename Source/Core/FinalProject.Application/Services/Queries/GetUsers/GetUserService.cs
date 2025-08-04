using FinalProject.Application.Interface.Context;
using FinalProject.Common.PageInation;

namespace FinalProject.Application.Services.Queries.GetUsers
{
    public class GetUserService : IGetUserService
    {

        private readonly IDatabaseContext _databaseContext;
        public GetUserService(IDatabaseContext databaseContex)
        {
            _databaseContext = databaseContex;

        }

        public ResulGetUsertDto Execute(RequestClassDto request)
        {
            var users = _databaseContext.Users.AsQueryable();
            if (!string.IsNullOrEmpty(request.SearchKey))
            {
                users = users.Where(p => p.Fullname.Contains(request.SearchKey));
            }

            int rowsize = 0;

            var userlist= users.ToPaged(request.Page, 20, out rowsize).Select(p => new GetUserDto
            {
                Id = p.Id,
                Fullname = p.Fullname,
                Email = p.Email,
                Password = p.Password,
            }
            ).ToList();


            return new ResulGetUsertDto
            {
                Users = userlist,
                Rows = rowsize,

            };

        }
    }
    
}