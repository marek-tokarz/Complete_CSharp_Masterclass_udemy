namespace StockPriceAlertSystem
{
    // Define the delegate that will be used for the event
    public delegate void StockPriceChangedHandler(string message);

    // Define the Stock class which includes the event system
    public class Stock
    {
        // Declare the event using the delegate
        public event StockPriceChangedHandler OnStockPriceChanged;

        // Private field to store the stock price
        private decimal _price;

        // Private field to store the threshold
        private decimal _threshold;

        //TODO

        // Property to get and set the stock price
      
        public decimal Price
        {
            // Set the new price
            // Raise the event if the price drops below the threshold
            get { return _price; }

            set
            {
                _price = value;
                if (_price < Threshold)
                {
                    // Raise if the price drops below the threshold
                    RaiseStockPriceChangedEvent("Stock price is below threshold!");
                }
            }
        }

        // Property to get and set the alert threshold
        public decimal Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }

        // Method to raise the stock price changed event
        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            // Invoke the event
            OnStockPriceChanged?.Invoke(message);
        }
    }

    // Define the subscriber class which reacts to the event
    public class StockAlert
    {
        // Method that handles the event and prints a message to the console
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine("Stock alert: " + message);
        }
    }

    // Program class to simulate the stock price changes and test the event system
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Stock and StockAlert
            Stock stock = new Stock();
            StockAlert alert = new StockAlert();

            // Subscribe to the stock price changed event
            stock.OnStockPriceChanged += alert.OnStockPriceChanged;

            // Set the alert threshold
            stock.Threshold = 120m;

            // Simulate stock price changes
            stock.Price = 130m; // No alert
            stock.Price = 110m; // Alert triggered

            // Wait for user input to close the console
            Console.ReadKey();
        }
    }
}
