using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SelfMailer.Entities.CodeFirst
{
    public class MailServer
    {
        [Key]
        public int ID { get; set; }
        public string Host { get; set; }
        public string Username { get; set; }
        public Password Password { get; set; }

        public virtual ICollection<Sender> Senders { get; set; }
    }
    public class Password
    {
        public string Value { get; set; }
        public bool AllowSave { get; set; }
    }
}
