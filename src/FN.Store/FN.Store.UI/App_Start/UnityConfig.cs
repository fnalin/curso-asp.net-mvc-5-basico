using FN.Store.Data.EF;
using FN.Store.Data.EF.Repositories;
using FN.Store.Domain.Contracts.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace FN.Store.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            //github.com/unitycontainer/unity/wiki/Unity-Lifetime-Managers
            container.RegisterType<FNStoreDataContextEF>();

            container.RegisterType<IProdutoRepository, ProdutoRepositoryEF>();
            container.RegisterType<ITipoDeProdutoRepository, TipoDeProdutoRepositoryEF>();
            container.RegisterType<IUsuarioRepository, UsuarioRepositoryEF>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}