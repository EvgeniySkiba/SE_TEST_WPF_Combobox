using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboboxBinding
{
    public class Model
    {
        public IList<string> Standards
        {
            get
            {
                return new List<string>() { "First", "Sec" };
            }
        }
    }

    public class Person
    {
        public string Standard { get; set; }
    }
}
