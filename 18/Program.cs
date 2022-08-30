68
{
    internal class Program
    {
    
        static uint Akkerman(uint m, uint n)
        {
            if (m == 0)  
                return n + 1;
            else
              if ((m != 0) && (n == 0))
                return Akkerman(m - 1, 1);  
            else
                return Akkerman(m - 1, Akkerman(m, n - 1));  
        }

        static void Main(string[] args)
        {
            Console.Write("Введите значение m: ");
            uint m = Convert.ToUInt32(Console.ReadLine()); 
            Console.Write("Введите значение n: ");  
            uint n = Convert.ToUInt32(Console.ReadLine()); 
            uint A = Akkerman(m, n); 
            Console.WriteLine($"A({m},{n}) = {A}"); 
            Console.ReadKey(); 
        }
    }
}

