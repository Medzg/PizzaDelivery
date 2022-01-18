using Autofac;
using FluentValidation;

namespace PizzaDelivery.Domain
{
    /// <summary>
    /// The domain module.
    /// </summary>
    public class DomainModules : Module
    {
        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Entites.Order>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(ThisAssembly).AsClosedTypesOf(typeof(IValidator<>)).AsImplementedInterfaces()
                .InstancePerDependency();
        }
    }
}