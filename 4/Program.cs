int [] array = new int[4];
int count = 0;
for (int i = 0; i < 4; i++)
    array[i] = new Random().Next(100, 1000);

Console.WriteLine("[" + string.Join(",", array) + "]");   

var result = array.Count(x => x % 2 == 0);
Console.WriteLine(result);