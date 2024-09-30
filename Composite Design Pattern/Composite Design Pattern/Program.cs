using Composite_Design_Pattern.Interfaces;
using Composite_Design_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileSystem file1 = new File("File1.txt");
            IFileSystem file2 = new File("File2.txt");

            Directory root = new Directory("Root");
            Directory subDir = new Directory("SubDir");

            root.Add(file1);
            subDir.Add(file2);
            root.Add(subDir);

            root.Display(1);
        }
    }
}
