54
{
    internal class Program
    {
  
        static void sort_buble(int[,] m)
        {
            int c;
            for (int k = 0; k < m.GetLength(0); k++)
            {
                for (int i = 0; i < m.GetLength(1) - 1; i++)
                {
                    for (int j = m.GetLength(1) - 2; j >= i; j--)
                        if (m[k,j] < m[k,j + 1])
                        {
                            c = m[k, j];
                            m[k, j] = m[k, j + 1];
                            m[k, j + 1] = c;
                        }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк двумерного массива: ");
            uint n = Convert.ToUInt32(Console.ReadLine());  
            Console.Write("Введите количество столбцов двумерного массива: ");
            uint m = Convert.ToUInt32(Console.ReadLine());  

            int[,] matrix = new int[n, m];  

            Random rnd = new Random(); 
            Console.WriteLine("Сгенерирован двумерный массив: ");
            for (int i = 0; i < n; i++)  
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(0, 50); 
                    Console.Write($"{matrix[i, j]}\t");  
                }
                Console.WriteLine();
            }
            sort_buble(matrix);  
            Console.WriteLine("Отсортированный по строкам двумерный массив (по убыванию): ");
            for (int i = 0; i < n; i++)   
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");  
                }
                Console.WriteLine();
            }

            Console.ReadKey();  
        }
    }
}

