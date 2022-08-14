
int[,] matrix = new int[2, 2];
for (int i = 0; i < 2; i ++)
{
    for (int j = 0; j< 2; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
    }
    
}
for (int i =0; i<2; i++)
{
    for (int j = 0; j< 2; j++)
        Console.Write(matrix[i, j]+ "\t");
    Console.WriteLine();
}


int a = ((matrix[0, 0] + matrix[0, 1]) / 2);
int b = ((matrix[1, 0] + matrix[1, 0]) / 2);
Console.WriteLine(string.Join (",", a, b));

