using codecov_tutorial;
using NUnit.Framework;

namespace tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Program.Method1(2, 3), 5);
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Program.Method2(3, 2), 3);
        }
        
        [Test]
        public void Test3()
        {
            Assert.AreEqual(Program.Method2(2, 3), 3);
        }
    }
}