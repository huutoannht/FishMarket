using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FishMarket.Entities;
using FishMarket.Interfaces;
using FishMarket.BLO;
using AutoMapper;

namespace FishMarket.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUserDataService _userDataService;
        private readonly IMapper _mapper;
        public HomeController(IUserDataService userDataService, IMapper mapper)
        {
            _userDataService = userDataService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(MembershipModel membershipModel)
        {
            UserBussinessService userBussinessService = new UserBussinessService(_userDataService, _mapper);
            TransactionalInformation transaction;
            Membership membership  = userBussinessService.Login(membershipModel, out transaction);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
