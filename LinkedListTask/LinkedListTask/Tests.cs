using System;
using LinkedList;
using NUnit.Framework;

namespace LinkedListTask
{
    [TestFixture]
    public class Tests
    {
        
        private LinkedList<int> list = new LinkedList<int>();

        public void init()
        {
            for (int i = 0; i < 100; i++)
            {
                list.add(i + 1);
            }
        }

        [Test]
        public void getTest()
        {
            Assert.AreEqual(15, list.get(14));
        }
        
        [Test]
        public void addTest()
        {
            init();
            Assert.AreEqual(78, list.get(77));
        }
        
        [Test]
        public void removeTest()
        {
            init();
            list.remove(55);
            Assert.AreEqual(57, list.get(55));
        }
    }
}