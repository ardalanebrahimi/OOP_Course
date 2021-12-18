namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IProperty[] properties = PropertyService.SearchProperties();

            foreach (IProperty prop in properties)
                System.Console.WriteLine(prop.Print());
        }
    }
}
