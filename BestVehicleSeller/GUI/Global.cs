using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    static class Global
    {
        private static Engine param = new Engine();

        public static Engine Param
        {
            get { return param; }
            set { param = value; }
        }
    }
}
