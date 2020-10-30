using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_PoP
{
    public class Battery
    {
        string name;
        double batteryLife;
        int power;
        int cells;

        public Battery(string name, double batteryLife, int power, int cells)
        {
            if (name != null && name.Length != 0)
            {
                this.name = name;
            }
            else
            {
                Console.WriteLine("Name cannot be empty!");
                this.name = null;
            }

            if(batteryLife > 0 && power > 0 && cells > 0)
            {
                this.batteryLife = batteryLife;
                this.power = power;
                this.cells = cells;
            }   
            else
            {
                Console.WriteLine("All of the elements of the battery must be over 0!");
                this.batteryLife = -1;
                this.power = -1;
                this.cells = -1;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                name = value;
            }
        }

        public double BatteryLife
        {
            get { return batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery Life must not be negative");
                }

                batteryLife = value;
            }
        }

        public int Power
        {
            get { return power; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery Power must not be negative");
                }

                power = value;
            }
        }

        public int Cells
        {
            get { return cells; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery Cells must not be negative");
                }

                cells = value;
            }
        }

        public string toString()
        {
            return "Battery Information = " + name + "; " + batteryLife + " hours; " + power + " mAh; " + cells + "-cells";
        }
    }
}
