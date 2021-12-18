namespace OOP
{
    public abstract class Property : IProperty
    {
        public double Area { get ; set; }
        public string Address { get ; set; }
        public abstract double GetPrice();
        public abstract string Print();
        internal abstract double GetUnitPrice();
    }
}
