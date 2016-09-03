using EmailCommunicator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Mail;

namespace AImoduleTesting
{
    
    
    /// <summary>
    ///This is a test class for EmailSenderTest and is intended
    ///to contain all EmailSenderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EmailSenderTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for EmailSender Constructor
        ///</summary>
        [TestMethod()]
        public void EmailSenderConstructorTest()
        {
            EmailSender target = new EmailSender();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ComposeDefaultEmail
        ///</summary>
        [TestMethod()]
        public void ComposeDefaultEmailTest()
        {
            EmailSender target = new EmailSender(); // TODO: Initialize to an appropriate value
            target.ComposeDefaultEmail();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ComposeFinalEmail
        ///</summary>
        [TestMethod()]
        public void ComposeFinalEmailTest()
        {
            EmailSender target = new EmailSender(); // TODO: Initialize to an appropriate value
            target.ComposeFinalEmail();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MailMessage
        ///</summary>
        [TestMethod()]
        public void MailMessageTest()
        {
            EmailSender target = new EmailSender(); // TODO: Initialize to an appropriate value
            string toAddr = string.Empty; // TODO: Initialize to an appropriate value
            string subject = string.Empty; // TODO: Initialize to an appropriate value
            string body = string.Empty; // TODO: Initialize to an appropriate value
            target.MailMessage(toAddr, subject, body);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for sendMail
        ///</summary>
        [TestMethod()]
        public void sendMailTest()
        {
            MailMessage msg = null; // TODO: Initialize to an appropriate value
            EmailSender.sendMail(msg);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
