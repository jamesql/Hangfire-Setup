using Hangfire;

namespace Hangfire2
{
    public class HangfireConfig
    {
        private Methods pkg = new Methods();
        
        public HangfireConfig()
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
            RCJMInit();
            FNFMInit();
        }

        private void RCJMInit()
        {
            RecurringJob.AddOrUpdate(() => pkg.Log("Test RC Job"), Cron.Minutely());
        }

        private void FNFMInit()
        {
            BackgroundJob.Enqueue(() => pkg.Log("Test BG Job"));
        }
    }
}
