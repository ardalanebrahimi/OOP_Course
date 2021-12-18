namespace OOP
{
    public class House : ResidentialProperty
    {
        public int WholeArea { get ; set; }

        public override double GetPrice()
        {
            var price = this.GetUnitPrice() * this.Area;
            price *= GetAgeDeductionRatio();
            price += (this.GetUnitPrice() * this.WholeArea * 0.2);

            return price;
        }

        public override string Print()
        {
            return $"House, Area:{Area}, WholeArea:{WholeArea}, Address: {Address}, Price: {GetPrice()}";
        }

    }
}
