﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ups.OA.EFDAL;
using System.Linq;
using Ups.OA.Model;
using Ups.OA.IDAL;

namespace Ups.OA.UnitTest.dal
{
    /// <summary>
    /// CustomerDalTests 的摘要说明
    /// </summary>
    [TestClass]
    public class CustomerDalTest
    {
        public CustomerDalTest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
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

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO:  在此处添加测试逻辑
            //
        }

        [TestMethod]
        public void testAddCustomer()
        {
            ICustomerDal dal = new CustomerDal();
            for (int i = 0; i < 10; i++)
            {
                dal.Add(new Customer()
                {
                    CusName = i + "sss"
                });
            }

            IQueryable<Customer> temp = dal.GetEntities(u => u.CusName.Contains("ss"));

            //断言
            Assert.AreEqual(true, temp.Count() >= 10);
        }
    }
}
