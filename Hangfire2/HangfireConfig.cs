using Hangfire;
using Hangfire.Common;
using Hangfire.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire2
{
    public class HangfireConfig
    {
        Methods pkg = new Methods();
        
        public HangfireConfig()
        {
            RCJMInit();
            FNFMInit();
        }

        private void RCJMInit()
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
            RecurringJob.AddOrUpdate(() => pkg.Log("Test RC Job"), Cron.Minutely());
        }

        private void FNFMInit()
        {

        }

    }
}
