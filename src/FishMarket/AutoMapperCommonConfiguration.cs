using AutoMapper;
using FishMarket.Entities;
using System;

namespace Models
{
    public class AutoMapperCommonConfiguration
    {
        #region Singleton

        private readonly static Lazy<AutoMapperCommonConfiguration> LazyInstance = new Lazy<AutoMapperCommonConfiguration>(() => new AutoMapperCommonConfiguration());

        public static AutoMapperCommonConfiguration Instance
        {
            get { return LazyInstance.Value; }
        }

        #endregion

        public static void Configure()
        {
            ConfigUser();
        }

        private static void ConfigUser()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<MembershipModel, Membership>());
            Mapper.Initialize(cfg => cfg.CreateMap<Membership, MembershipModel>());
        }

    }
}