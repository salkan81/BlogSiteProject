using BLL.Abstract;
using BLL.Concrete;
using DAL.Context;
using DAL.Repository.Abstract;
using DAL.Repository.Concrete;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteProject
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
            services.AddControllersWithViews().AddFluentValidation(a=>a.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BlogSiteDbConStr")));
            services.AddSession();


            //Repositories
            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            services.AddScoped<IArticleDal, ArticleRepositoryDal>();
            services.AddScoped<IArticlesAndTopicsDal, ArticlesAndTopicsRepositoryDal>();
            services.AddScoped<ITopicDal,TopicRepositoryDal>();
            services.AddScoped<IUserDal,UserRepositoryDal>();
            services.AddScoped<IUserRegisterDal, UserRegisterRepositoryDal>();
            services.AddScoped<IUsersAndTopicsDal, UsersAndTopicsRepositoryDal>();


            //Services
            services.AddScoped<IArticleService, ArticleManager>();
            services.AddScoped<IArticlesAndTopicsService, ArticlesAndTopicsManager>();
            services.AddScoped<ITopicService, TopicsManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserRegisterService, UserRegisterManager>();
            services.AddScoped<IUsersAndTopicsService, UsersAndTopicsManager>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseSession();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
