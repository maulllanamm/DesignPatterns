using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternServices_.StructuralPatterns.Composite
{
    public class Composite : IComponent
    {
        public string Name { get; set; }

        List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public string DisplayPrice()
        {
            var res = new StringBuilder();
            foreach (var component in components)
            {
                res.AppendLine(component.DisplayPrice());
            }
            return res.ToString();
        }

        
    }
}
