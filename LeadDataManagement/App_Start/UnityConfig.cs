using LeadDataManagement.Repository;
using LeadDataManagement.Repository.Interface;
using LeadDataManagement.Services;
using LeadDataManagement.Services.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace LeadDataManagement
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<ILeadRepository, LeadRepository>();
            container.RegisterType<ILeadService, LeadService>();
            container.RegisterType<ILeadMasterDataRepository, LeadMasterDataRepository>();
        }
    }
}