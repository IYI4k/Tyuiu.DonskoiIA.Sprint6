using System;
using Tyuiu.DonskoiIA.Sprint6.Task6.V16.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.CollectTextFromFile("ab", Path.Combine(new string[] { Path.GetTempPath(), "Task6V16Input.txt" }));

            Assert.AreEqual("ab 7b hebab b wellb", res);
        }
    }
}