using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01._02_Laptop_Shop
{
    class Battery
    {
        //define fields
        private string type;
        private int cells;
        private int mah;

        //define constructor
        public Battery()
        {
        }

        public Battery(string type, int cells, int mah)
        {
            this.Type = type;
            this.Cells = cells;
            this.mah = mAh;
        }

        //define properties

        public string Type
        {
            get { return this.type; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery type can't be empty!");
                }
                this.type = value;
            }
        }

        public int Cells
        {
            get { return this.cells; }
            set
            {
                if (value <= 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Battery cells out of range!");
                }
                this.cells = value;
            }
        }

        public int mAh
        {
            get { return this.mah; }
            set 
            {
                if (value <= 0 || value > 10000)
                {
                    throw new ArgumentOutOfRangeException("Battery capacity oru of range!");
                }
                this.mah = value;
            }
        }
    }
}
