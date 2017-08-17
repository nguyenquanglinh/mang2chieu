using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChenSoVaoMang
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] a = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            int[,] b = new int[3, 3] { { 1, 0, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            var s = NhanCham.Program.DienVongTrong(a, b);
            CollectionAssert.AreEqual(s, new int[,] { { 1,2,3,4,5 }, { 1,16, 24,32,5 }, {1, 16,  24,32,5 }, { 1, 16, 24, 32, 5 },{ 1, 2, 3, 4, 5 } });
        }
    }
}
