namespace OOP
{
    class PropertyService
    {
        public static IProperty[] SearchProperties()
        {
            IProperty[] properties = new Property[]{
                new Apartment() { Area = 100, Address = Address.Zone1 },
                new Apartment() { Area = 200, Address = Address.Zone2  },
                new Apartment() { Area = 120, Address = Address.Zone2  },
                new Apartment() { Area = 120, Address = Address.Zone3  },
                
                new House() { Area = 120, WholeArea = 300, Address = Address.Zone3  },
                new House() { Area = 90, WholeArea = 200, Address = Address.Zone4  },
                
                new Warehouse() { Area = 300, Height = 6, Address = Address.Zone1  },
                new Warehouse() { Area = 300, Height = 5, Address = Address.Zone2  },
                new Warehouse() { Area = 400, Height = 4, Address = Address.Zone3  },
            };
            return properties;
        }
    }
}
