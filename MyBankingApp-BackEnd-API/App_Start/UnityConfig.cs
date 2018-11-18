using MyBankingApp_BackEnd_Library.Repository;
using System.Web.Http;
using Unity;
using Unity.WebApi;
using Moq;
using MyBankingApp_BackEnd_Library.Domain;
using System.Collections.Generic;

namespace MyBankingApp_BackEnd_API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      var myMock = new Mock<IComptesRepository>();
      myMock.Setup(o => o.FindAll()).Returns(
         new List<Compte> {
            new Compte { Numero="Fake001", Proprietaire="Hamza Hamza", Solde=1000M},
            new Compte { Numero="Fake002", Proprietaire="Imen Imen", Solde=2000M},
            new Compte { Numero="Fake003", Proprietaire="Alaa Alaa", Solde=3000M},
           }
        );

      container.RegisterInstance<IComptesRepository>(myMock.Object);      // e.g. container.RegisterType<ITestService, TestService>();
      //container.RegisterType<IComptesRepository, ComptesRepositoryImp_Memory>();


      GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
