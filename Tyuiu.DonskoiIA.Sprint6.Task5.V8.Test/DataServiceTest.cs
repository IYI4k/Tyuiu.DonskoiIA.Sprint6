using System;
using Tyuiu.DonskoiIA.Sprint6.Task5.V8.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.LoadFromDataFile(Path.Combine(new string[] { Path.GetTempPath(), "Task5V8Input.txt" }));

            CollectionAssert.AreEqual(new double[] { -2, -7, -9, -1.5}, res);
        }
    }
}