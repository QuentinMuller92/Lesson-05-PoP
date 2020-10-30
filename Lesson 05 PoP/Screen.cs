using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_PoP
{
    public class Screen
    {
        double length;
        string pixel;
        string sensor;

        public Screen(double length, string pixel, string sensor)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                Console.WriteLine("Screen length must be over 0!");
                this.length = -1;
            }

            if (pixel != null && pixel.Length != 0 && sensor != null && sensor.Length != 0)
            {
                this.pixel = pixel;
                this.sensor = sensor;
            }
            else
            {
                Console.WriteLine("Pixel and/or Sensor cannot be empty!");
                this.pixel = null;
                this.sensor = null;
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Screen length must not be negative");
                }

                length = value;
            }
        }

        public string Pixel
        {
            get
            {
                return pixel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Screen Pixel cannot be empty!");
                }

                pixel = value;
            }
        }

        public string Sensor
        {
            get
            {
                return sensor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Screen Sensor cannot be empty!");
                }

                sensor = value;
            }
        }

        public string toString()
        {
            return "Screen information = " + length + "cm; " + pixel + "; " + sensor;
        }
    }
}
