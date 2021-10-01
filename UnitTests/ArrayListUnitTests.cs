using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExercise1;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        
        [TestMethod]
        public void TestLength()
        {

            IList list = new ArrayList();

            Assert.AreEqual(0, list.Length);

            for (int i = 0; i < 10; i++)
            {
                list.Append(i);
            }

            Assert.AreEqual(10, list.Length);

            for (int i =0; i < 32; i++)
            {
                list.Append(i);
            }

            Assert.AreEqual(42, list.Length);

        }

        [TestMethod]
        public void TestIsEmpty()
        {

            IList list = new ArrayList();

            Assert.IsTrue(list.IsEmpty);

            for (int i = 0; i < 10; i++)
            {
                list.Append(i);
            }

            Assert.IsFalse(list.IsEmpty);

        }

        [TestMethod]
        public void TestFirst()
        {
            IList list = new ArrayList();

            Assert.ThrowsException<NullReferenceException>(() =>
            {
                int i = list.First;
            });

            for (int i = 0; i < 10; i++)
            {
                list.Append(i);
            }

            Assert.AreEqual(10, list.Length);

            for (int i = 0; i < 32; i++)
            {
                list.Append(i);
            }

            Assert.AreEqual(42, list.Length);
        }

        [TestMethod]
        public void TestLast()
        {
        }

        [TestMethod]
        public void TestAppend()
        {
        }

        [TestMethod]
        public void TestPrepend()
        {
        }

        [TestMethod]
        public void TestInsertAfter()
        {
        }

        [TestMethod]
        public void TestInsertAt()
        {
        }

        [TestMethod]
        public void TestFirstIndexOf()
        {
        }

        [TestMethod]
        public void TestRemove()
        {
        }

        [TestMethod]
        public void TestRemoveAt()
        {
        }

        [TestMethod]
        public void TestClear()
        {
        }

        [TestMethod]
        public void TestReverse()
        {
        }
    }

}


