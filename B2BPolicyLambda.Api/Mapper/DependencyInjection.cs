using AutoMapper;
using B2BPolicyLambda.Api.Mapper.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace B2BPolicyLambda.Api.Mapper
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
