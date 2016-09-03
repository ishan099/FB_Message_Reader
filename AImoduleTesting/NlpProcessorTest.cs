using EmailCommunicator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AImoduleTesting
{
    
    
    /// <summary>
    ///This is a test class for NlpProcessorTest and is intended
    ///to contain all NlpProcessorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NlpProcessorTest
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
        ///A test for processData
        ///</summary>
        [TestMethod()]
        public void processDataTest()
        {
            NlpProcessor target = new NlpProcessor(); // TODO: Initialize to an appropriate value
            target.processData();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for compareCategories
        ///</summary>
        [TestMethod()]
        public void compareCategoriesTest()
        {
            NlpProcessor target = new NlpProcessor(); // TODO: Initialize to an appropriate value
            Dictionary<string, int> dict = null; // TODO: Initialize to an appropriate value
            string emailMeaasge = string.Empty; // TODO: Initialize to an appropriate value
            string emailId = string.Empty; // TODO: Initialize to an appropriate value
            int emailRef = 0; // TODO: Initialize to an appropriate value
            target.compareCategories(dict, emailMeaasge, emailId, emailRef);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectionAndAssignProcess
        ///</summary>
        [TestMethod()]
        public void SelectionAndAssignProcessTest()
        {
            NlpProcessor target = new NlpProcessor(); // TODO: Initialize to an appropriate value
            target.SelectionAndAssignProcess();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AssignGroupWithLearning
        ///</summary>
        [TestMethod()]
        public void AssignGroupWithLearningTest()
        {
            NlpProcessor target = new NlpProcessor(); // TODO: Initialize to an appropriate value
            int emailRef = 0; // TODO: Initialize to an appropriate value
            Dictionary<string, int> dict = null; // TODO: Initialize to an appropriate value
            int cusCode = 0; // TODO: Initialize to an appropriate value
            string emailMeaasge = string.Empty; // TODO: Initialize to an appropriate value
            string EmailAdd = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.AssignGroupWithLearning(emailRef, dict, cusCode, emailMeaasge, EmailAdd);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NlpProcessor Constructor
        ///</summary>
        [TestMethod()]
        public void NlpProcessorConstructorTest()
        {
            NlpProcessor target = new NlpProcessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
