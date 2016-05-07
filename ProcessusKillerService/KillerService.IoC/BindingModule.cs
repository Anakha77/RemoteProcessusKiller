using Ninject.Modules;

namespace KillerService.IoC
{
    public class BindingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ServiceLibrary.IKillerService>().To<ServiceLibrary.KillerService>();
        }
    }
}
