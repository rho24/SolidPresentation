using Autofac;
using SolidPresentation;

namespace Program
{
    internal class Program
    {
        private static void Main(string[] args) {
            var container = BuildContainer();

            var messageConstructor = container.Resolve<MessageConstructor>();
        }

        private static IContainer BuildContainer() {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(typeof (MessageConstructor).Assembly).AsImplementedInterfaces().AsSelf();
            return builder.Build();
        }
    }
}