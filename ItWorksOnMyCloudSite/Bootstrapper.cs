using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;

namespace ItWorksOnMyCloudSite
{
    public class Bootstrapper
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModule<CloudModule>();

            return builder.Build();
        }
    }

    public class CloudModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CloudStorageAccount>()
                   .UsingConstructor(() => CloudStorageAccount.Parse(
                       CloudConfigurationManager.GetSetting("StorageConnectionString")))
                   .InstancePerHttpRequest();

            base.Load(builder);
        }
    }
}