using Composite_Design_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Design_Pattern.Model
{
    internal class Directory:IFileSystem
    {
        private string _name;
        private List<IFileSystem> _children = new List<IFileSystem>();

        public Directory(string name)
        {
            _name = name;
        }

        public void Add(IFileSystem component)
        {
            _children.Add(component);
        }

        public void Remove(IFileSystem component)
        {
            _children.Remove(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);
            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
