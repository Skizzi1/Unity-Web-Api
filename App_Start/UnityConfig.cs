using System.Web.Http;
using Unity;
using Unity.WebApi;
using unity_webapi.Interfaces;
using unity_webapi.Models;
using unity_webapi.Repository;

namespace unity_webapi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICrud<Employee, int>, EmployeeRepository>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}