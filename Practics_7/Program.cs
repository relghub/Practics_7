class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Вітаємо в обміннику валюти!");
        Console.WriteLine("___________txrch____________");
        Console.WriteLine("Американський долар - натисніть 0.");
        Console.WriteLine("Євро - натисніть 1.");
        Console.WriteLine("Польський злотий - натисніть 2.");
        Console.WriteLine("___________txrch____________");
        Console.WriteLine("Введіть валюту, в яку хочете конвертувати гроші: ");
        int currency = Convert.ToInt32(Console.ReadLine());
        CurrencySwitch(currency);
    }

    static void CurrencySwitch(int currency)
    {
        int rate;
        string cur_abbrev;
        switch (currency)
        {
            case 0:
                rate = (int)Rates.USD;
                cur_abbrev = "USD";
                Conversion(rate, cur_abbrev);
                break;
            case 1:
                rate = (int)Rates.EUR;
                cur_abbrev = "EUR";
                Conversion(rate, cur_abbrev);
                break;
            case 2:
                rate = (int)Rates.PLN;
                cur_abbrev = "PLN";
                Conversion(rate, cur_abbrev);
                break;
            case -1:
                Console.WriteLine("Валюти не існує. Повторіть спробу.");
                break;
        }
    }

    static void Conversion(int rate, string abbrev)
    {
        Console.WriteLine($"Курс продажу цієї валюти становить {rate} гривень.");
        Console.WriteLine("Яку суму в гривнях бажаєте сконвертувати?");
        float amount_to_convert = Convert.ToInt32(Console.ReadLine());
        float converted_amount = amount_to_convert / rate;
        Console.WriteLine("Підсумкова сума після конвертації: " +
                          $"{converted_amount} {abbrev}.");
    }
    enum Rates
    {
        USD = 38, EUR = 41, PLN = 9
    }

}