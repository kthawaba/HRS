﻿using HRS.Models.Entities;

namespace HRS.Models.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> Get_AllUser();

    }
}
