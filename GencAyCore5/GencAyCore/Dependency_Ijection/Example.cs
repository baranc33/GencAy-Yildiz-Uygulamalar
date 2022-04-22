using Dependency_Ijection.Services;

namespace Dependency_Ijection
{
    public class Example
    {
        public Example()
        {

            // program.cs teki IserviceCollection Bir IoC container dır
            IServiceCollection services = new ServiceCollection();// built - in loc
            // biz servislerimi default olarak bu şekilde ekliyebiliriz
            services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));
            services.Add(new ServiceDescriptor(typeof(TestLog), new TestLog()));

            ServiceProvider provider = services.BuildServiceProvider();// buda bize Direk Container döner
            provider.GetService<ConsoleLog>();// New lemeden direk nesne bu şekilde oluşturulabilir.

        }
    }
}
