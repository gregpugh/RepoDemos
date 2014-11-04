[assembly: WebActivator.PreApplicationStartMethod(typeof(CodeTalk.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(CodeTalk.App_Start.NinjectWebCommon), "Stop")]

namespace CodeTalk.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    
    //5b.1
    using CodeTalk.Domain.Contracts.Services;
    using CodeTalk.ServiceLayer;
    using CodeTalk.Domain.Contracts.Repositories;
    using CodeTalk.DataSource;
    using CodeTalk.DataSource.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
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
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //5b.0
            kernel.Bind<ITalkService>().To<TalkService>().InRequestScope();
            kernel.Bind<ICommentService>().To<CommentService>().InRequestScope();
            //5e,5f
            kernel.Bind<ITalkRepository>().To<TalkRepository>().InRequestScope();
            kernel.Bind<ICommentRepository>().To<CommentRepository>().InRequestScope();
            //5g,5h
            kernel.Bind<CodeTalkContext>().To<CodeTalkContext>().InRequestScope();
            //5i
            //kernel.Bind<CodeTalkContext>().To<FakeCodeTalkContext>().InRequestScope();
            

        }        
    }
}
