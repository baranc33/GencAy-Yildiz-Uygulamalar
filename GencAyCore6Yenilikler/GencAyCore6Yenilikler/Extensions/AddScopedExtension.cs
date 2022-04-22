namespace GencAyCore6Yenilikler.Extensions
{
    static public class AddScopedExtension
    {
        public static IServiceCollection AddScopedExtens(this IServiceCollection services)
        {


            services.AddScoped<IUnitOfWork, UnitOfWork>();


            //services.AddScoped<IRefreshTokenService, RefreshTokenService>();
            //services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();




            return services;
        }
    }
    interface IUnitOfWork { }
    class UnitOfWork : IUnitOfWork { }
}
