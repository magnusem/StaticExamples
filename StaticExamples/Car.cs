namespace StaticExamples
{
    public class Car
    {
        private string _licensePlate;
        private int _price;

        public static int CarTracker;
        public static int PriceTracker;
        public static int PlateTracker;


        public string LicensePlate
        {
            get { PlateTracker++; return _licensePlate; }
            set { _licensePlate = value; }
        }

        public int Price
        {
            get { PriceTracker++; return _price; }
            set { _price = value; }
        }

        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
        }

        public string PrintUsageStatistics()
        {
            return "Price: " + " " + Price + " License Plate: " + LicensePlate;
        }
    }
}