using System;
using Tyuiu.DonskoiIA.Sprint6.Task1.V2.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetMassFunction(2, 4);
            CollectionAssert.AreEqual(new double[] { 10.3, 16.17, 28.1}, res);
        }
    }
}