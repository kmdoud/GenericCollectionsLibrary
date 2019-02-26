using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsLibrary
{
    public class StringList : List<string>
    {

        public void Add(string str1, string str2, string str3, string str4)
        {
            this.Add(str1);
            this.Add(str2);
            this.Add(str3);
            this.Add(str4);
        }
        public void Add(string str1, string str2, string str3)
        {
            this.Add(str1);
            this.Add(str2);
            this.Add(str3);
        }
        public void Add(string str1, string str2)
        {
            this.Add(str1);
            this.Add(str2);
        }
        public StringList() : base()
        {

        }
    }
}
