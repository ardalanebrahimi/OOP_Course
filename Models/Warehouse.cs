namespace OOP
{
    public class Warehouse : Property
    {
        public int Height { get; set; }

        public override double GetPrice()
        {
            var price = this.GetUnitPrice() * this.Area;
            if (Height > 5)
                price *= 1.2;

            return price;
        }

        public override string Print()
        {
            return $"Warehouse, Area:{Area}, Height:{Height}, Address: {Address}, Price: {GetPrice()}";
        }

        internal override double GetUnitPrice()
        {
            if (Address == OOP.Address.Zone1 || Address == OOP.Address.Zone2)
                return 100;
            if (Address == OOP.Address.Zone3 || Address == OOP.Address.Zone4)
                return 80;

            return 0;
        }

    }
}
