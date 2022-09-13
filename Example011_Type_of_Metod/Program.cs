// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Первый тип методов - ничего не принимает и ничего не возвращает

void Type1 ()
{
    Console.WriteLine("Author - Shishkina YY");
}

//Ка вызывается метод - Наименование и круглые скобки и ;
Type1();

//Второй тип методов - принимает аргументы, но ничего не возвращает

void Type2 (string msg)
{
    Console.WriteLine(msg);
}

Type2("Текст сообщения");

void Type21 (string msg, int count) // Пример метода, который принимает 2 аргмента разных типов
{
    int i=0;
    while (i<count)
    {
        i++;
        Console.WriteLine(msg);
    }
}    

Type21(msg:"Сообщение",count:4); // пример явного указания присвоение значений аргументам метода

//Третий тип методов - которые не принимает аргументы, но возвращает значения

int Type3() //При использовании метода, нужно явно указат тип переменной, которую возвращает Метод
{
    return DateTime.Now.Year;
}

int year = Type3(); //переменной присваивается значение, которое возвращает метод
Console.WriteLine(year);

//Четвертый тип методов - которые принимают аргументы и возвращают значения

string Type4 (int count, string c)
{
    int i=0;
    string result = String.Empty;
    while (i<count)
    {
        result=result+c;
        i++;
    }
    return result;
}

string Text = Type4(count:10, c:"q");
Console.WriteLine(Text);


string Type41 (int count, string c) //Пример четвертого метода с использованием цикла for вместо while
{
    string result = String.Empty;
    for (int i=0; i < count; i++)
    {
        result=result+c;
    }
    return result;
}

string Text1 = Type41(count:10, c:"q");
Console.WriteLine(Text1);

//Пример использования цикла в цикле

for (int i=2; i < 10; i++)
    {
        for (int j=2; j<10; j++)
        {
            Console.Write($"{i*j}, ");
        }
        Console.WriteLine();
    }

//=====Работа над текстом======
//Дан, текст. В тексте нужно заменить все пробелы черточками, 
//Все буквы "к" на "К"
//Все буквы "С" на маленькие "с"

string TextZ = "- Я думаю, - сказал князь, улыбаясь - что,"
+ "ежели бы Вас послали вместо нашего милого Винцегероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace (string TextY, char OldValue, char NewValue)
{
    string resultY = String.Empty;
    int length = TextY.Length;
for (int i=0; i < length; i++)
{
    if (TextY[i]==OldValue)
    {
        resultY=resultY + $"{NewValue}";
    }
    else
    {
        resultY =resultY + $"{TextZ[i]}";
    }
}
return resultY;
}

string NewText = Replace(TextZ, OldValue:' ', NewValue:'|');
Console.WriteLine(NewText);
NewText = Replace(NewText,'к','К');
Console.WriteLine(NewText);
NewText = Replace(NewText, OldValue:'с', NewValue:'С');
Console.WriteLine(NewText);

        


