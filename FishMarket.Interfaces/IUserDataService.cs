using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishMarket.Interfaces;
using FishMarket.DTO;
using FishMarket.Entities;

namespace FishMarket.Interfaces
{
    /// <summary>
    /// User Data Service
    /// </summary>
    public interface IUserDataService : IDataRepository, IDisposable
    {
        void CreateUser(Membership membership);
        void UpdateUser(Membership membership);
        Membership Login(Membership membership);
    }
}
