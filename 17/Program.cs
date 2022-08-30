66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите значение M: ");
            uint M = Convert.ToUInt32(Console.ReadLine());
        
            Console.Write("Введите значение N: ");
            uint N = Convert.ToUInt32(Console.ReadLine());
            uint sum = 0;  
            for (uint i = M; i <= N; i++)  
                sum += i; 
            Console.WriteLine($"Сумма чисел в промежутке от {M} до {N} = {sum}"
            Console.ReadKey(); 
        }
    }
}

