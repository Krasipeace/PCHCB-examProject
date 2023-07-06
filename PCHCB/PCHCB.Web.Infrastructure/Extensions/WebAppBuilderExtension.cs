namespace PCHCB.Web.Infrastructure.Extensions
{
    using System.Reflection;

    using Microsoft.Extensions.DependencyInjection;

    using static PCHCB.Common.ExceptionMessages;

    public static class WebApplicationBuilderExtensions
    {
        /// <summary>
        /// This method registers all services with their interfaces and implementations of given assembly.
        /// The assembly is taken from the type of random service interface or implementation provided.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(serviceType) ?? 
                throw new InvalidOperationException(InvalidServiceType);

            Type[] implementationTypes = serviceAssembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (Type implementationType in implementationTypes)
            {
                Type? interfaceType = implementationType.GetInterface($"I{implementationType.Name}") ?? 
                    throw new InvalidOperationException(string.Format(InvalidImplementationType, implementationType.Name));
                services.AddScoped(interfaceType, implementationType);
            }
        }
    }
}
