using System;

using ParticleSwarm;

namespace Functions
{
    public class MyTask : Task
    {
        public MyTask(double[] minvalues, double[] maxvalues) :
            base(minvalues, maxvalues)
        {

        }
        //Число обращений к ц.ф.
        
        public override double FinalFunction(double[] position)
        {
            double result = 0.0;
            double a1 = 0.39, a2 = 0.34, a3 = 0.27;
           
            ///Mail.ru
                double C1 = 0.03588585, C2 = -0.138227586, C3 = 0.000517602, C4 = -0.293152542, C5 =5.3478E-05;
            //Yandex
             //    double C1 = 0.260661765, C2 = -0.394270436, C3 = 0.002799755, C4 = -1.025488136, C5 = 0.000289268;  
            //Yahoo
            //   double C1 = 0.07088571, C2 = -0.244925049, C3 = 0.001740407, C4 = -0.434255085, C5 = 0.000164464;  
            //Google
            //     double C1 = 0.35470224, C2 = -0.477399242, C3 = 0.005967108, C4 = -1.184725424, C5 = 0.000563876;

            /////////////////////////////////////////////////////////////////////////////////////

           /* foreach (double x in position)
            {
                result += x * x;
            }*/

            result = a1*(C1 * Math.Log(position[0]) + C2 * Math.Log(position[1])) +
                a2* (C3 * Math.Log(position[2])) +
                    a3*(C4 * Math.Log(position[3]) + C5 * Math.Log(position[4]));

            result -= GetPenalty(position, 10000.0);
           
            return result;
        }
    }
}
