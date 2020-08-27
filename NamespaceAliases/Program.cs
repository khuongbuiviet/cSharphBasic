using System;
using Chapter04 = KDQ.Prog_CSharp.Chapter04; //Chapter04 là alias của namespace

namespace NamespaceAliases
{
    class Program
    {
        static void Main(string[] args)
        {
            Chapter04.NamespaceExample NSEx = new Chapter04.NamespaceExample();
            Console.WriteLine(NSEx.GetNamespace());
            Console.ReadLine();
        }
    }
}

namespace KDQ.Prog_CSharp.Chapter04
{
    class NamespaceExample
    {
        public string GetNamespace()
        {
            return this.GetType().Namespace;
        }
    }
}
