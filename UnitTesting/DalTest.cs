using EmailCommunicator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;

namespace UnitTesting
{
    
    
    /// <summary>
    ///This is a test class for DalTest and is intended
    ///to contain all DalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DalTest
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


        internal virtual Dal CreateDal()
        {
            // TODO: Instantiate an appropriate concrete class.
            Dal target = null;
            return target;
        }

        /// <summary>
        ///A test for BeginTran
        ///</summary>
        [TestMethod()]
        public void BeginTranTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.BeginTran();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CommitTran
        ///</summary>
        [TestMethod()]
        public void CommitTranTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.CommitTran();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetNumberOfRecords
        ///</summary>
        [TestMethod()]
        public void GetNumberOfRecordsTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            string StrSQL = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetNumberOfRecords(StrSQL);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RollbackTran
        ///</summary>
        [TestMethod()]
        public void RollbackTranTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.RollbackTran();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for callSp
        ///</summary>
        [TestMethod()]
        public void callSpTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            string spName = string.Empty; // TODO: Initialize to an appropriate value
            SqlParameter[] paraList = null; // TODO: Initialize to an appropriate value
            target.callSp(spName, paraList);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for closeConn
        ///</summary>
        [TestMethod()]
        public void closeConnTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.closeConn();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for exeNonQury
        ///</summary>
        [TestMethod()]
        public void exeNonQuryTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            string sqlString = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.exeNonQury(sqlString);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getDataset
        ///</summary>
        [TestMethod()]
        public void getDatasetTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            string StrSQL = string.Empty; // TODO: Initialize to an appropriate value
            DataSet expected = null; // TODO: Initialize to an appropriate value
            DataSet actual;
            actual = target.getDataset(StrSQL);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for openConn
        ///</summary>
        [TestMethod()]
        public void openConnTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.openConn();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DBConn
        ///</summary>
        [TestMethod()]
        public void DBConnTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            SqlConnection actual;
            actual = target.DBConn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Transobj
        ///</summary>
        [TestMethod()]
        public void TransobjTest()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            SqlTransaction actual;
            actual = target.Transobj;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BeginTran
        ///</summary>
        [TestMethod()]
        public void BeginTranTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.BeginTran();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CommitTran
        ///</summary>
        [TestMethod()]
        public void CommitTranTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.CommitTran();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetNumberOfRecords
        ///</summary>
        [TestMethod()]
        public void GetNumberOfRecordsTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            string StrSQL = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetNumberOfRecords(StrSQL);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RollbackTran
        ///</summary>
        [TestMethod()]
        public void RollbackTranTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.RollbackTran();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for callSp
        ///</summary>
        [TestMethod()]
        public void callSpTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            string spName = string.Empty; // TODO: Initialize to an appropriate value
            SqlParameter[] paraList = null; // TODO: Initialize to an appropriate value
            target.callSp(spName, paraList);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for closeConn
        ///</summary>
        [TestMethod()]
        public void closeConnTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.closeConn();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for exeNonQury
        ///</summary>
        [TestMethod()]
        public void exeNonQuryTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            string sqlString = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.exeNonQury(sqlString);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getDataset
        ///</summary>
        [TestMethod()]
        public void getDatasetTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            string StrSQL = string.Empty; // TODO: Initialize to an appropriate value
            DataSet expected = null; // TODO: Initialize to an appropriate value
            DataSet actual;
            actual = target.getDataset(StrSQL);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for openConn
        ///</summary>
        [TestMethod()]
        public void openConnTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            target.openConn();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DBConn
        ///</summary>
        [TestMethod()]
        public void DBConnTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            SqlConnection actual;
            actual = target.DBConn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Transobj
        ///</summary>
        [TestMethod()]
        public void TransobjTest1()
        {
            Dal target = CreateDal(); // TODO: Initialize to an appropriate value
            SqlTransaction actual;
            actual = target.Transobj;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
