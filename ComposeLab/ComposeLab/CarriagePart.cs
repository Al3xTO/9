using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposeLab
{
    internal class CarriagePart : ICarriageComponent
    {
        private string _name;
        

        public CarriagePart(string name)
        {
            _name = name;
        }

        public string getDescription()
        {
            return _name;          
        }
    }
}
