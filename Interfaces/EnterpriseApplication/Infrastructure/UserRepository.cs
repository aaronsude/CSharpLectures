using Interfaces.EnterpriseApplication.Application.Interfaces;
using Interfaces.EnterpriseApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.EnterpriseApplication.Infrastructure
{
    internal class FileStorageUserRepository : IUserRepository
    {
        public User GetUser(int id)
        {
            Console.WriteLine("User loaded from local files!");
            return new User();
        }
    }
}
