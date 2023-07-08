//for (int i = 2; i <= 10; i++)
//{
//    for (int j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} * {j} = {i * j}");
//    }
//    Console.WriteLine();
//}

// ==== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.

// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '/'); // заменить пробелы на черточки

Console.WriteLine(newText); // в консоле увидеть новый текст
Console.WriteLine();
newText = Replase(newText, 'к', 'К'); // заменить пробелы на черточки
Console.WriteLine(newText); 
newText = Replase(newText, 'с', 'С'); // заменить пробелы на черточки
Console.WriteLine(newText);