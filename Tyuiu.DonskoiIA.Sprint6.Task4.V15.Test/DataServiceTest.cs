using System;
using Tyuiu.DonskoiIA.Sprint6.Task4.V15.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.GetMassFunction(2,4);

            CollectionAssert.AreEqual(new double[] {5.57, 14.02, 12.37}, res);
        }
    }
}