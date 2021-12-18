namespace OOP
{
    public class Apartment : ResidentialProperty
    {
        public int Floor { get ; set; }
        public bool Elevator { get ; set; }
        public bool Balcony { get ; set; }

        public override double GetPrice()
        {
            var price = this.GetUnitPrice() * this.Area;
            price *= GetElevatorDeductionRatio();
            price *= GetAgeDeductionRatio();

            return price;
        }

        public override string Print()
        {
            return $"Apartment, Area:{Area}, Address: {Address}, Price: {GetPrice()}";
        }

        private double GetElevatorDeductionRatio()
        {
            if (Floor > 2 & !Elevator)
                return 0.8;
            else
                return 1;
        }
    }
}
