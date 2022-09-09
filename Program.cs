using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IProperty> properties = PropertyService.SearchProperties();

            foreach (IProperty prop in properties)
                System.Console.WriteLine(prop.Print());
        }
    }
}
