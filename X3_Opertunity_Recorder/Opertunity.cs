using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X3_Opertunity_Recorder
{
    public class Opertunity
    {
        string _name, _sector;
        List<string> _resource = new List<string>();

        public Opertunity(string name, string sector, List<string> resource)
        {
            _name = name;
            _sector = sector;
            _resource = resource;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Sector
        {
            get { return _sector; }
            set { _sector = value; }
        }

        public List<string> Resource
        {
            get { return _resource; }
            set { _resource = value; }
        }
    }
}
