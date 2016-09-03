using EmailCommunicator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AImoduleTesting
{
    
    
    /// <summary>
    ///This is a test class for NlpLogicTest and is intended
    ///to contain all NlpLogicTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NlpLogicTest
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
        ///A test for NlpLogic Constructor
        ///</summary>
        [TestMethod()]
        public void NlpLogicConstructorTest()
        {
            NlpLogic target = new NlpLogic();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ArrangeText
        ///</summary>
        [TestMethod()]
        public void ArrangeTextTest()
        {
            string text = " i need GPRS Settings"; // TODO: Initialize to an appropriate value
            string[] expected = {"i"}; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = NlpLogic.ArrangeText(text);
            Assert.AreEqual(expected[0].ToString(), actual[0].ToString());
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BuildFreqTable
        ///</summary>
        [TestMethod()]
        public void BuildFreqTableTest()
        {
            LinkedList<string> tokens = null; // TODO: Initialize to an appropriate value
            Dictionary<string, int> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, int> actual;
            actual = NlpLogic.BuildFreqTable(tokens);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListWordsByFreq
        ///</summary>
        [TestMethod()]
        public void ListWordsByFreqTest()
        {
            NlpLogic target = new NlpLogic(); // TODO: Initialize to an appropriate value
            Dictionary<string, int> strIntDict = null; // TODO: Initialize to an appropriate value
            Dictionary<string, int> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, int> actual;
            actual = target.ListWordsByFreq(strIntDict);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDict
        ///</summary>
        [TestMethod()]
        public void ToDictTest()
        {
            NlpLogic target = new NlpLogic(); // TODO: Initialize to an appropriate value
            string[] words = null; // TODO: Initialize to an appropriate value
            Dictionary<string, int> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, int> actual;
            actual = target.ToDict(words);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
