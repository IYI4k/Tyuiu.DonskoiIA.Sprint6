using System;
using Tyuiu.DonskoiIA.Sprint6.Task2.V29.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetMassFunction(2, 4);
            CollectionAssert.AreEqual(new double[] { -7.03, -12.99, -17.55 }, res);
        }
    }
}