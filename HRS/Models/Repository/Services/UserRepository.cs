using HRS.Infrastructure.Extension;
using HRS.Models.Entities;
using HRS.Models.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
 

namespace HRS.Models.Repository.Services
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationdbContext context;

        public UserRepository(ApplicationdbContext context)
        {
            this.context = context;
        }

        public async Task<List<User?>> Get_AllUser()
        {
            return await  context.User.Where(a => a.Status == true).ToListAsync();
        }
        public async Task<User> Get_User(int UserID)
        {
            return await context.User.SingleOrDefaultAsync(a => a.Id == UserID);
        }
    }
}
