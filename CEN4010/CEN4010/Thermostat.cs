using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN4010
{
    public class Thermostat
    {
        public int getTemperature()
        {
            if (temp.getTemperature() > setTemperature)
            {
                acOn = true;
            }
            else
            {
                acOn = false;
            }
            temp.changeTemperature(acOn);
            return temp.getTemperature();
        }
        private int setTemperature = 80;
        private bool acOn = false;
        private Temperature temp = new Temperature();
    }
}
