using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.Exceptionmess
{
    internal  class MyExceptions
    {
        public static Dictionary<string, string> excmesslist = new Dictionary<string, string>();
                    
        

        public MyExceptions()
        {
            
            excmesslist.Add("Div 0 ", "Dont give 0 for deno");
            excmesslist.Add("IOR", "index is out of range");
            excmesslist.Add("ue", "unknown exception");
            excmesslist.Add("age is less", "NotHunt");
            excmesslist.Add("age is more", "NotHunt2");
        }
    }
}
