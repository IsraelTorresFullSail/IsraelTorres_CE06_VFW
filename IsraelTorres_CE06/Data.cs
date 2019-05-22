using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelTorres_CE06
{
    public class Data
    {
        private string _direction;
        private decimal _miles;
        private decimal _hours;
        private string _mode;

        public string Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
        public decimal Miles
        {
            get { return _miles; }
            set { _miles = value; }
        }
        public decimal Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
        public string Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        public static readonly List<Data> _Data = new List<Data>();

        public static List<Data> DataList
        {
            get
            {
                if(_Data.Count < 1)
                {
                    //Load Data data
                }
                return _Data;
            }
        }
    }
}
