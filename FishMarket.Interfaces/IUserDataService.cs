using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishMarket.Interfaces;
using FishMarket.DTO;

namespace FishMarket.Interfaces
{
    /// <summary>
    /// User Data Service
    /// </summary>
    public interface IUserDataService : IDataRepository, IDisposable
    {
        void CreateUser(Meber user);
        void UpdateUser(Users user);
        Users Login(Users user);
    }
}
