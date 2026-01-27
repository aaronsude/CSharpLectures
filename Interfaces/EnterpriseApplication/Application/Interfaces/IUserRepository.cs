using Interfaces.EnterpriseApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.EnterpriseApplication.Application.Interfaces
{
    internal interface IUserRepository
    {
        User GetUser(int id);
    }
}
