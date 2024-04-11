using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposeLab
{
    internal class CompositeCarriage
    {
        private List<ICarriageComponent> _components = new List<ICarriageComponent>();

        public void AddComponent(ICarriageComponent component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(ICarriageComponent component)
        {
            _components.Remove(component);
        }

        public string getCarDescription()
        {
            StringBuilder description = new StringBuilder();
            description.AppendLine("Карета состоит из:");

            foreach (var component in _components)
            {
                description.AppendLine(component.getDescription()); 
            }
            return description.ToString();
        }
    }
}
