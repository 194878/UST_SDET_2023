using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order
    {
        BookType[] books=new BookType[7];
        public int TotalCost { get; set; }
        public string? OrderDate { get; set; }
    }
}
