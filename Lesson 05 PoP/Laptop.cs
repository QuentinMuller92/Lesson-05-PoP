using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_PoP
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int RAM;
        private string graphicsCard;
        private int HDD;
        private Screen screen;
        private int price;
        private Battery battery;

        public Laptop(string model, int price)
        {
            if (price > 0)
            {
                this.price = price;
            }
            else
            {
                Console.WriteLine("Laptop price must be over 0!");
                this.price = -1;
            }

            if (model != null && model.Length != 0)
            {
                this.model = model;
            }
            else
            {
                Console.WriteLine("Laptop model cannot be empty!");
                this.model = null;
            }
        }

        public Laptop(string model, int price, string manufacturer, Battery battery, string processor, int RAM, string graphicsCard, int HDD, Screen screen)
        {
            if (price > 0 && HDD > 0 && RAM > 0)
            {
                this.price = price;
                this.HDD = HDD;
                this.RAM = RAM;
            }
            else
            {
                Console.WriteLine("Laptop price, HDD and RAM must be over 0!");
                this.price = -1;
                this.HDD = -1;
                this.RAM = -1;
            }

            if (model != null && model.Length != 0 && manufacturer != null && manufacturer.Length != 0 && processor != null && processor.Length != 0 && graphicsCard != null && graphicsCard.Length != 0)
            {
                this.model = model;
                this.manufacturer = manufacturer;
                this.processor = processor;
                this.graphicsCard = graphicsCard;
            }
            else
            {
                Console.WriteLine("Laptop model, manufacturer, processor and graphics card cannot be empty!");
                this.model = null;
                this.manufacturer = null;
                this.processor = null;
                this.graphicsCard = null;
            }            
            
            this.screen = screen;
            this.battery = battery;            
        }

        public Laptop(string model, int price, string manufacturer, Battery battery)
        {
            if (model != null && model.Length != 0 && manufacturer != null && manufacturer.Length != 0)
            {
                this.model = model;
                this.manufacturer = manufacturer;
            }
            else
            {
                Console.WriteLine("Laptop model and manufacturer cannot be empty!");
                this.model = null;
                this.manufacturer = null;
            }

            if (price > 0)
            {
                this.price = price;
            }
            else
            {
                Console.WriteLine("Laptop price must be over 0!");
                this.price = -1;
            }

            this.battery = battery;
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Laptop Model cannot be empty!");
                }

                model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Laptop Manufacturer cannot be empty!");
                }

                manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Laptop Processor cannot be empty!");
                }

                processor = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return graphicsCard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Laptop graphics card cannot be empty!");
                }

                graphicsCard = value;
            }
        }

        public int Ram
        {
            get { return RAM; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Laptop RAM must not be negative");
                }

                RAM = value;
            }
        }

        public int Hdd
        {
            get { return HDD; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Laptop HDD must not be negative");
                }

                HDD = value;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Laptop price must not be negative");
                }

                price = value;
            }
        }

        public string toString()
        {
            string response = $"Laptop information = {model}; {price}lv.; {manufacturer}; {processor}; {RAM}GB; {graphicsCard}; {HDD}GB";
            if (battery != null)
            {
                response += "\n" + battery.toString();
            }
            if (screen != null)
            {
                response += "\n" + screen.toString();
            }
            return response;
        }
    }
}
