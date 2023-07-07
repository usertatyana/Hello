// Вид 1 это метод который ничего не возвращает и ничего не принимает
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Вид 2 ничего не возвращает но принимает какие то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщение");

void Method21(string msg, int count)  // именнованые аргументы
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4); // К какому аргументу и какое значение хотим присвоиить

// Вид 3 аргументы он не принимает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 4 что то принимают и возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);