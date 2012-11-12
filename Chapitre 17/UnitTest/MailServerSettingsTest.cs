using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelfMailer.Library;

namespace UnitTest
{
    [TestClass]
    public class MailServerSettingsTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        public void FromEmailTestValid()
        {
            MailServerSettings target = new MailServerSettings();
            string expected = "test@abc.com";
            string actual;
            target.FromEmail = "test@abc.com";
            actual = target.FromEmail;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FromEmailTestNull()
        {
            MailServerSettings target = new MailServerSettings();
            target.FromEmail = "test";
            Assert.IsNull(target.FromEmail);
        }

    }
}
