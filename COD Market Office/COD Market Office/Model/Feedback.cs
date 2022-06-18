using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model
{
    class Feedback<T>
    {
        public bool status { get; set; }
        public T value { get; set; }
        public string errorMessage { get; set; }
    }
}
