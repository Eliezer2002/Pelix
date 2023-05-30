using Pelix.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelix.DAL.Interfaces
{
    public interface IUserRepository
    {
        void Save(User user);
        void Update(User user);
        List<User> GetAll();
        User GetbyId(int Id);
        void Remove(User user);
    }
}
