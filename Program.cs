internal class Program
{
    public static double ctof(double c) {
        double f = (9.0 / 5) * c + 32;
        return f;
    }
    public static double ftoc(double f) {
        double c = (5.0 / 9) * (f - 32);
        return c;
    }

    private static void Main(string[] args)
    {
        double f;
        double c;
        int choice;
        do {
            Console.WriteLine("Menu.");
            Console.WriteLine("1. Chuyen tu F sang C");
            Console.WriteLine("2. Chuyen tu C sang F");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice) {
                case 0: 
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Nhap nhiet do F: ");
                    f = float.Parse(Console.ReadLine());
                    Console.WriteLine("Nhiet do C la: " + ftoc(f));
                    break;
                case 2:
                    Console.WriteLine("Nhap nhiet do C: ");
                    c = double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhiet do F la: " + ctof(c));
                    break;
            }
        } while (choice != 0);
    }
}