 
using Autofac;
using Autofac.Core;
using Nile.Admin.Controllers;
using Nile.Core.Caching;
using Nile.Core.Infrastructure;
using Nile.Core.Infrastructure.DependencyManagement;
 

namespace Nile.Admin.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //we cache presentation models between requests
            builder.RegisterType<HomeController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
