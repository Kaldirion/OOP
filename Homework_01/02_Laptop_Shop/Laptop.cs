using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01._02_Laptop_Shop
{
    class Laptop
    {
        //define fields
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery = new Battery();
        private decimal batteryLife;
        private decimal price;

        //define constructors

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(
            string model,
            string manufacturer,
            string processor,
            string ram,
            string graphicsCard,
            string hdd,
            string screen,
            decimal batteryLife,
            decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        //define properties

        public string Model
        {
            get { return this.model; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model can't be empty!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer can't be empty!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Processor can't be empty!");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("RAM can't be empty!");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Graphics Card can't be empty!");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("HDD can't be empty!");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Screen can't be empty!");
                }
                this.screen = value;
            }
        }

        public decimal BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Battery live can't be less than zero");
                }
                this.batteryLife = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price can't be negavite number!");
                }
                this.price = value;
            }
        }
        //define methods

        public override string ToString()
        {
            string model = this.Model;
            string manufacturer = this.Manufacturer;
            string processor = this.Processor;
            string ram = this.Ram;
            string graphicsCard = this.GraphicsCard;
            string hdd = this.Hdd;
            string screen = this.Screen;
            string batteryType = this.battery.Type;
            string batteryCells = Convert.ToString(this.battery.Cells);
            string batterymAh = Convert.ToString(this.battery.mAh);
            string batteryLife = Convert.ToString(this.batteryLife);
            string price = Convert.ToString(this.Price);

            string Result = "Laptop Description :\n";

            Result = Result + "Model: " + model + "\n";

            if (!string.IsNullOrEmpty(manufacturer))
            {
                Result = Result + "Manufacturer: " + manufacturer + "\n";
            }
            if (!string.IsNullOrEmpty(processor))
            {
                Result = Result + "Processor: " + processor + "\n";
            }
            if (!string.IsNullOrEmpty(ram))
            {
                Result = Result + "RAM: " + ram + " GB"+ "\n";
            }
            if (!string.IsNullOrEmpty(graphicsCard))
            {
                Result = Result + "Graphics Card: " + graphicsCard + "\n";
            }
            if (!string.IsNullOrEmpty(hdd))
            {
                Result = Result + "HDD: " + hdd + "\n";
            }
            if (!string.IsNullOrEmpty(screen))
            {
                Result = Result + "Screen: " + screen + "\n";
            }
            
            Result = Result + "Price: " + price;
            return Result;
        }
    }
}
