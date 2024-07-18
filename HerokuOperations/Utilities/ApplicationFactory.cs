using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class ApplicationFactory
    {
        public static string getUrl() {
            return "https://the-internet.herokuapp.com/";
        }

        public static string getPlatform() {
            return "web";
        }
    }
}
