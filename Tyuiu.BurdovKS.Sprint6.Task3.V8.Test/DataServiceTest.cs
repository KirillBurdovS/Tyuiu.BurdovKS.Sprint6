







using Tyuiu.BurdovKS.Sprint6.Task3.V8.Lib;



namespace Tyuiu.BurdovKS.Sprint6.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();


            int[,] valueArray = new int[5, 5]
            {

            { -10, 10, -7, 19, 6 },
            { 15, -13, -19, 9, 1 },
            { -20, -15, -6, 8, -4 },
            { 10, 18, -5, 9, -6 },
            { 16, -10, 4, 15, 16 }

            };

            int[,] res = ds.Calculate(valueArray);

            int[,] waitArray = new int[5, 5]
{

            { -10, 10, -7, 19, 6 },
            { 15, -13, -19, 9, 1 },
            { -20, -15, -6, 8, -4 },
            { 0, 0, -5, 9, 0 },
            { 16, -10, 4, 15, 16 }

            };


            CollectionAssert.AreEqual(waitArray, res);

        }
    }
}



        