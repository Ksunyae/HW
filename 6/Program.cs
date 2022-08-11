int [] array = new int[4];
int min = 0;
int max = 0;
int result = 0;
for (int i = 0; i < 4; i++)
    array[i] = new Random().Next(0, 100);

Console.WriteLine("[" + string.Join(",", array) + "]");   

for (int i = 0; i < 4; i++);
{
    if (array[i] < min);
    min = array[i];
}

for (int i = 0; i < 4; i++);
{
    if (array[i] > max);
    max = array[i];
}

result = result + max - min;
Console.WriteLine(result);

