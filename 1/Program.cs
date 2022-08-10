 void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();




// Вид2
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}

Method21("Текст", 4);
Method21(count: 4, msg: "Новый текст");




//3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//4
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

     while (i < count)
    {
         result = result + c;
         i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);



string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
         result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);