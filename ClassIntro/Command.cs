namespace ClassIntro
{
    public class Command
    {
        private const double _price = 3.5;
        public double ChangePrice(double price)
        {
            return price + _price;
        }

        public double ChangePrice()
        {
            return 45;
        }
    }
}
