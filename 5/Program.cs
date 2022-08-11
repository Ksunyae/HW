int [] array = new int[4];
int count = 0;
for (int i = 0; i < 4; i++)
    array[i] = new Random().Next(0, 100);

Console.WriteLine("[" + string.Join(",", array) + "]");   

int sum = 0;
sum = sum + array[1] + array[3];
Console.WriteLine(sum);
