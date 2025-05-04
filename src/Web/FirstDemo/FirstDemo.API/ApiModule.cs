using Autofac;

namespace FirstDemo.Api
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<LoginModel>().AsSelf();
            
            base.Load(builder);
        }
    }


}
