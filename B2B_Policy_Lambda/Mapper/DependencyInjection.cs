using AutoMapper;
using B2B_Policy_Lambda.Mapper.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace B2B_Policy_Lambda.Mapper
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMapperServices(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new PolicyProfile());
                mc.AllowNullCollections = true;
            });
            var mapper = mappingConfig.CreateMapper();
            mapper.ConfigurationProvider.CompileMappings();

            services.AddSingleton(mapper);

            return services;
        }
    }
}
