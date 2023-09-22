using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BrovinaYV.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            return Convert.ToDouble(Math.Truncate(number).ToString());
        }
    }
}
