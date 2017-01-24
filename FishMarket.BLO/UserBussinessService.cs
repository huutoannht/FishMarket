using AutoMapper;
using FishMarket.Entities;
using FishMarket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMarket.BLO
{
    public class UserBussinessService
    {
        private IUserDataService _userDataService;
        private IMapper _mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        public UserBussinessService(IUserDataService userDataService, IMapper mapper)
        {
            _userDataService = userDataService;
            _mapper = mapper;
        }
        /// <summary>
        /// Create Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public Membership Login(MembershipModel membershipModel, out TransactionalInformation transaction)
        {
            transaction = new TransactionalInformation();
            Membership membership = null;
            try
            {

                _userDataService.CreateSession();
                _userDataService.BeginTransaction();
                var userEntity = _mapper.Map<MembershipModel, Membership>(membershipModel);
                membership = _userDataService.Login(userEntity);
                _userDataService.CommitTransaction(true);

                transaction.ReturnStatus = true;
                transaction.ReturnMessage.Add("User checked.");

            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                transaction.ReturnMessage.Add(errorMessage);
                transaction.ReturnStatus = false;
            }
            finally
            {
                _userDataService.CloseSession();
            }

            return membership;


        }
    }
}
