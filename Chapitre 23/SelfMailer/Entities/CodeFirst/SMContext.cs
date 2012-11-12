using System.Data.Entity;

namespace SelfMailer.Entities.CodeFirst
{
    public class SMContext : DbContext
    {
        public DbSet<MailServer> MailServers { get; set; }
        public DbSet<Sender> Senders { get; set; }
    }
}
