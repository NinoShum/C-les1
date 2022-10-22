/* Заменить пмробел черточкой /
мальнькую к заменить на большую К
С заменить на с
*/

string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";



// к типу строки применим способ, обращения к элементу по индексу
// string s = "qwerty"
//             012

//s[3] ---r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if ((text[i]) == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string NewText = Replace(text, ' ', '|');
Console.WriteLine(NewText);

Console.WriteLine();
NewText = Replace(NewText, 'к', 'К');
Console.WriteLine(NewText);

Console.WriteLine();
NewText = Replace(NewText, 'С', 'с');
Console.WriteLine(NewText);

