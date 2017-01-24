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
        public void CreateUser(Membership membership)
        {
            dbConnection.Memberships.Add(membership);
        }

        public Membership Login(Membership membership)
        {
            Membership memberValid = dbConnection.Memberships.Include("UsersInRoles").Include("Role").Where(m => m.Username == membership.Username && m.Password == membership.Password).FirstOrDefault();
            return memberValid;
        }

        public void UpdateUser(Membership membership)
        {
            throw new NotImplementedException();
        }
    }
}
