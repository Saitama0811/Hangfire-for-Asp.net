using System;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.Dashboard;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HangfireWebApi.Startup))]

namespace HangfireWebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = new DashboardOptions
            {
                Authorization = new[]
            {
                new LocalRequestsOnlyAuthorizationFilter()
            }
            };

            app.UseHangfireDashboard("/hangfire", options);
        }
    }
}
