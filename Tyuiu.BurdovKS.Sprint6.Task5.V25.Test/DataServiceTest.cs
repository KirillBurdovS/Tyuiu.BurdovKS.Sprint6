




using Tyuiu.BurdovKS.Sprint6.Task5.V25.Lib;


namespace Tyuiu.BurdovKS.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"D:\Users\djura\source\repos\Tyuiu.BurdovKS.Sprint6\Tyuiu.BurdovKS.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}