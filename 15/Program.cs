56
{
    internal class Program
    {
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
                {// заполнение случайными числами
                    Console.Write($"{matrix[i, j]}\t");  // вывод элемнетов матрицы на экран
                }
                Console.WriteLine();
            }
            int min_sum = Int32.MaxValue; // принимаем за минимум максимально возможное число
            int ind_row = -1; // индекс минимальной строки
            int sum = 0;  // сумма

            for (int i = 0; i < n; i++)  // циклы прохода по матрице
            {
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i,j];  // поиск суммы элементов строки
                }
                if (sum < min_sum)  // если сумма меньше 
                {
                    ind_row = i;  // переписываем значения
                    min_sum = sum;
                }
                sum = 0;  // обнуление суммы перед проходом следующей строки
            }
            // вывод значений на экран
            Console.WriteLine($"Минимальная сумма элементов {min_sum} находится в строке под номером {ind_row+1}");
            Console.ReadKey();
        }
    }
}

