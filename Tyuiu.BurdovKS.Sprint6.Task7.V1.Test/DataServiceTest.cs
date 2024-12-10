



using System.IO;
using Tyuiu.BurdovKS.Sprint6.Task7.V1.lib;

namespace Tyuiu.BurdovKS.Sprint6.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            string path = @"D:\Users\djura\source\repos\Tyuiu.BurdovKS.Sprint6\Tyuiu.BurdovKS.Sprint6.Task7.V1\bin\Debug\InPutFileTask7V1.txt";

            int[,] wait = new int[2, 2] { { 1, 0 },
                                          { 0, 1 } };
            int[,] res = ds.GetMatrix(path);
            CollectionAssert.AreEqual(wait, res);

        }
    }
}