58
{
    internal class Program
    {
       
        static void random_matrix(int[,] m)
        {
            Random rnd = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(0, 10);
                }
            }
        }
        
        static void print_matrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        
        static void mult_matrix(int[,] a, int[,] b, int[,] c)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < a.GetLength(1); k++)
                        c[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---- Программа умножения двух матриц АВ ----");
            Console.WriteLine("Внимание! Количество столбцов левой матрицы А должно равняться количеству строк матрицы В");
            Console.Write("Введите количество строк двумерного массива A: ");
            int n1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите количество столбцов двумерного массива А: ");
            int m1 = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Введите количество строк двумерного массива В: ");
            int n2 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите количество столбцов двумерного массива B: ");
            int m2 = Convert.ToInt32(Console.ReadLine()); 
            if (m1 != n2)   
            {
                Console.WriteLine("Умножение матриц невозможно!");
                Console.ReadKey();
                return;  
            }

            int[,] A = new int[n1, m1]; 
            int[,] B = new int[n2, m2]; 

            random_matrix(A); 
            random_matrix(B); 
            Console.WriteLine("Сгенерирован двумерный массив A: ");
            print_matrix(A); 
            Console.WriteLine("Сгенерирован двумерный массив B: ");
            print_matrix(B); 

            int[,] C = new int[n1, m2];  

            mult_matrix(A, B, C); 
            Console.WriteLine("Результат произведения А*B: ");
            print_matrix(C); 

            Console.ReadKey();
        }
    }
}
