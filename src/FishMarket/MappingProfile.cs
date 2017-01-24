using AutoMapper;
using FishMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishMarket
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Membership, MembershipModel>();
            CreateMap<MembershipModel, Membership>();
        }
    }
}
