using Business.Abstract;
using Business.Business;
using DataAccess.Abstracts;
using DataAccess.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace UurArticle
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            #region Dependencies

            //Article
            services.AddScoped<IArticleBusiness, ArticleBusiness>();
            services.AddScoped<IBlogArticleDal, BlogArticleDal>();

            //Category
            services.AddScoped<ICategoryBusiness, CategoryBusiness>();
            services.AddScoped<IBlogCategoryDal, BlogCategoryDal>();

            //User
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<IBlogUserDal, BlogUserDal>();

            #endregion

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
