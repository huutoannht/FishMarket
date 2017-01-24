using FishMarket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishMarket.DTO;
using FishMarket.Entities;

namespace FishMarket.DAO
{
    public class UserDataService : EntityFrameworkService, IUserDataService
    {
       
        public void CreateUser(Users user)
        {
            throw new NotImplementedException();
        }


        public Users Login(Users user)
        {
            User userChecked = dbConnection.Users.Where(u => u.Password == user.password).FirstOrDefault();
            return userChecked;
        }
        public void RollbackTransaction(bool closeSession)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
