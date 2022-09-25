// Вид 1 -> ничего не возвращают и ничего не принимают

/*
void Method1()
{
    Console.WriteLine("Автор Lavrik Alina");
}
Method1();   */

// Вид 2 -> ничего не возвращает и принимает аргументы
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения"); */

/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;                    // инкремент - увеличение на 1, дикримент - уменьшение
    }
}
// Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый текст"); */

// Вид 3 -> что-то возвращают и ничего не принимают
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); */

//  Вид 4 ->  что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "aal");
Console.WriteLine(res);