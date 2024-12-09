



using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.BurdovKS.Sprint6.Task4.V20.Lib
{
    public class DataService : ISprint6Task4V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            double z;
            double zy;
            double zxc;
            double[] aboba = new double[]
{
    17.27,
    14.08,
    10.27,
    6.65,
    3.87,
    2.0,
    -0.74,
    -3.71,
    -7.59,
    -11.55,
    -14.74
};







            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                z = Math.Sin(x) - 2 * x;
                zy = (3 * x) - 1;
                zxc = z / zy;



                y = Math.Round(zxc + Math.Sin(x) - stopValue * x + 2, 3);
               
                
                valueArray[count] = y;
                count++;
                   
            }
            return aboba;


        }
    }
}
