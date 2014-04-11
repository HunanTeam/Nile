using System;
using Nile.Core.Configuration;
using Nile.Core.Infrastructure.DependencyManagement;

namespace Nile.Core.Infrastructure
{
    /// <summary>
    /// Classes implementing this interface can serve as a portal for the 
    /// various services composing the Nop engine. Edit functionality, modules
    /// and implementations access most Nop functionality through this 
    /// interface.
    /// </summary>
    public interface IEngine
    {
        ContainerManager ContainerManager { get; }
        
        /// <summary>
        /// Initialize components and plugins in the nop environment.
        /// </summary>
        /// <param name="config">Config</param>
        void Initialize(NileConfig config);

        T Resolve<T>() where T : class;

        object Resolve(Type type);

        T[] ResolveAll<T>();
    }
}
