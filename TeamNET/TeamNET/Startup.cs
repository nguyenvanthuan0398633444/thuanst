using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models;
using TeamNET.Models.Entity;
using TeamNET.Repository.Implement;
using TeamNET.Repository.Interface;
using TeamNET.Service.Implement;
using TeamNET.Service.Interface;

namespace TeamNET
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
            services.AddControllersWithViews();
            services.AddEntityFrameworkNpgsql().AddDbContext<OJTDbContext>(opt =>
                            opt.UseNpgsql(Configuration.GetConnectionString("DbConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<OJTDbContext>();
            services.AddScoped<IEventContentService, EventContentService>();
            services.AddScoped<IEventContentRepository, EventContentRepository>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseService, CourseService>();

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ITrackingChartRepository, TrackingChartRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IAbilityRepository, AbilityRepository>();
            services.AddScoped<IAbilityService, AbilityService>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddSignalR();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapHub<ChatHub>("/chathub");
            //});

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
