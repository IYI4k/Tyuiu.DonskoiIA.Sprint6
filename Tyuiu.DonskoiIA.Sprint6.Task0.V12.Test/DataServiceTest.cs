using System;
using Tyuiu.DonskoiIA.Sprint6.Task0.V12.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3);
            Assert.AreEqual(1.741, res);
        }
    }
}