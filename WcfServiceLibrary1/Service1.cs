using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to 
    // change the class name "Service1" in both code and config file 
    // together.
    public class Service1 : IService1
    {
        /// <summary>
        /// This Function Returns summation of two integer numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        /// <summary>
        /// This function returns subtraction of two numbers. 
        /// If number1 is smaller than number2 then this function returns 0
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Substract(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1 - number2;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// This function returns multiplication of two integer numbers.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        /// <summary>
        /// This function returns integer value of two integer number. 
        /// If num2 is 0 then this function returns 1
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Divide(int number1,int number2)
        {
            if (number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                return 1;
            }
        }
    }
}
