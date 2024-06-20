using System.Linq;
using System.Reflection;

namespace ConectaPorto.Api
{
    public class RegisterServices
    {
        public static void Register(IServiceCollection services)
        {
            // Obtém todas as interfaces no assembly do projeto "ConectaPorto"
            var interfaces = Assembly.Load("ConectaPorto")
                .GetTypes().AsQueryable().Where(i => i.IsInterface);

            // Para cada interface encontrada, registra a implementação correspondente usando AddScoped
            foreach (var @interface in interfaces)
            {
                var implementation = Assembly.Load("ConectaPorto")
                    .GetTypes()
                    .FirstOrDefault(t => @interface.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

                if (implementation != null)
                {
                    services.AddScoped(@interface, implementation);
                }
            }
        }
    }
}
