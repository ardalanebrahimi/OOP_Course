namespace OOP
{
    public abstract class ResidentialProperty : Property
    {
        public int Rooms { get; set; }
        public int Age { get; set; }
        internal double GetAgeDeductionRatio()
        {
            if (Age < 3)
                return 1;
            else if (Age < 10)
                return 0.95;
            else if (Age < 25)
                return 0.8;
            else
                return 0.7;
        }
        internal override double GetUnitPrice()
        {
            if (Address == OOP.Address.Zone1)
                return 100;
            if (Address == OOP.Address.Zone2)
                return 90;
            if (Address == OOP.Address.Zone3)
                return 80;
            if (Address == OOP.Address.Zone4)
                return 70;

            return 0;
        }

    }
}
