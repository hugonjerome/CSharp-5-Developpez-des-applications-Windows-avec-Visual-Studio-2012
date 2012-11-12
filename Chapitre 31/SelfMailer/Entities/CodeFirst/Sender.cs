using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SelfMailer.Entities.CodeFirst
{
    public class Sender
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<MailServer> MailServers { get; set; }
    }
}
