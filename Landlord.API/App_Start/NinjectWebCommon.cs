[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Landlord.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Landlord.App_Start.NinjectWebCommon), "Stop")]

namespace Landlord.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using Ninject.Web.WebApi;
    using GraphQL;
    using GraphQL.Types;
    using Landlord.API.Mutations;
    using Landlord.API.Queries;
    using Landlord.API.Schema;
    using Landlord.API.Types;
    using Landlord.SRC.Repositories;
    using Landlord.SRC.Repositories.Contracts;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Landlord.API.Models;
    using Landlord.API.Types.Property.InputTypes;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);

                
                // VERY IMPORTANT: ONLY FOR WEBAPI PROJECTS.
                // This following line is needed if we want to use ninject to construct the api controllers.
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);


                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IPropertyRepository>().To<PropertyRepository>();
            kernel.Bind<IPaymentRepository>().To<PaymentRepository>();
            kernel.Bind<IDocumentExecuter>().To<DocumentExecuter>();
            kernel.Bind<PropertyQuery>().ToSelf();
            kernel.Bind<PropertyMutation>().ToSelf();
            kernel.Bind<PropertyType>().ToSelf();
            kernel.Bind<PropertyInputType>().ToSelf();
            kernel.Bind<PaymentType>().ToSelf();
            kernel.Bind<ISchema>().To<LandlordSchema>();
            
            // Pass the same kernel
            kernel.Bind<GraphQL.IDependencyResolver>().To<GraphQLDependencyResolver>().WithConstructorArgument(kernel);
        }
    }
}