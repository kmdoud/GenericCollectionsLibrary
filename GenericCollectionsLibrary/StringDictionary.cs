using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsLibrary
{
    public class StringDictionary
    {
        private Dictionary<int, string> strings = new Dictionary<int, string>();

        public void Add(int key, string data)
        {
            strings.Add(key, data);
        }
        public string Get(int key)
        {
            return strings[key];
        }
        public List<string> values()
        {
            return strings.Values.ToList();
        }

    }
}
