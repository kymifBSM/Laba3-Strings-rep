using System.Runtime.InteropServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
////////////////////////////////////////////
///////////////////TASK 1///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово или строку к заданию 1(Проверка кол-во - Н): ");

string str1 = Console.ReadLine();
int count1 = 0;
int i1 = 0;
int len1 = str1.Length;

while (i1 < len1)
{
    if (str1[i1] == 'Н') count1++;
    i1++;
}

Console.WriteLine("Количество раз, когда встречается 'Н' :" + count1);

////////////////////////////////////////////
///////////////////TASK 2///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 2(Удаление слов на с): ");

string str2 = Console.ReadLine();
string[] words2 = str2.Split(" ");

StringBuilder result2 = new StringBuilder();

foreach (string word in words2)
{
    if (!word.StartsWith("с"))    
    {
        result2.Append(word + " ");
    }
}

Console.WriteLine("Обновлённая строка :" + result2.ToString().Trim());

////////////////////////////////////////////
///////////////////TASK 3///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 3(Вывод слов содержащих хотя бы одну - d): ");

string str3 = Console.ReadLine();
string[] words3 = str3.Split(" ");

foreach (string word in words3)
{
    if (word.Contains("d"))  
    {
        Console.WriteLine("Слова с буквой 'd': " + word);
    }
}

////////////////////////////////////////////
///////////////////TASK 4///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово или строку к заданию 4(Удваивает кол-во букв): ");

string str4 = Console.ReadLine();
StringBuilder result4 = new StringBuilder();

foreach (char letter in str4)
{
    result4.Append(letter.ToString() + letter.ToString());
}

Console.WriteLine("Обновлённая строка с удвоенными буквами: " + result4.ToString());

////////////////////////////////////////////
///////////////////TASK 5///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 5(Проверяет одинакова ли длина слов в строке): ");

string str5 = Console.ReadLine();
string[] words5 = str5.Split(" ");

int length = words5[0].Length;

foreach (string word in words5)
{
    if (word.Length != length)
    {
        Console.WriteLine("Длина не одинакова, переписывай");
        return;
    }
}

Console.WriteLine("Длина одинакова, молодец");

////////////////////////////////////////////
///////////////////TASK 6///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строки к заданию 6(Объединяет две строки и считает кол-во - da в строке): ");

string f1 = Console.ReadLine();
string f2 = Console.ReadLine();

string str6 = f1 + " " + f2;

int count6 = 0;

for (int i = 0; i < str6.Length - 1; i++)
{
    if (str6.Substring(i, 2) == "da")
    {
        count6++;
    }
}

Console.WriteLine("Комбинированная строка: " + str6);
Console.WriteLine("Количество раз, когда появляется 'da', равно: " + count6);

////////////////////////////////////////////
///////////////////TASK 7///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 7(Находит самое длинное слово и ставит его в начало): ");

string str7 = Console.ReadLine();
string[] words7 = str7.Split(' ');
string longestWord = "";

foreach (string word in words7)
{
    if (word.Length > longestWord.Length)
    {
        longestWord = word;
    }
}

str7 = longestWord + " " + str7.Replace(longestWord, "");

Console.WriteLine("Обновленная строка: " + str7);

////////////////////////////////////////////
///////////////////TASK 8///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 8(Кол-во букв 'y' стоящих на чётных местах): ");

string str8 = Console.ReadLine();
int count8 = 0;

for (int i = 0; i < str8.Length; i += 2)
{
    if (str8[i] == 'y')
    {
        count8++;
    }
}

Console.WriteLine("Количество букв 'y' на чётных местах равно: " + count8);

////////////////////////////////////////////
///////////////////TASK 9///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 9(Меняет все 'a' на 'A'): ");

string str9 = Console.ReadLine();
string updJ = str9.Replace('a', 'A');

Console.WriteLine("Обновлённая строка:" + updJ);

////////////////////////////////////////////
///////////////////TASK 10//////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 10(Определяет первая или последняя буква встречается чаще): ");

string str10 = Console.ReadLine();

int k1 = 0;
int k2 = 0;

for (int i = 0; i < str10.Length; i++)
{
    if (str10[i] == str10[0])
    {
        k1++;
    }
    if (str10[i] == str10[str10.Length - 1])
    {
        k2++;
    }
}

if (k1 > k2)
{
    Console.WriteLine("Первая буква встречается чаще");
}
else if (k1 < k2)
{
    Console.WriteLine("Последняя буква встречается чаще");
}
else
{
    Console.WriteLine("И первая, и последняя буквы встречаются одинаково часто");
}

////////////////////////////////////////////
///////////////////TASK 11//////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 11(Безумие запятых): ");
string str11 = Console.ReadLine();
int indexTochki = str11.IndexOf('.');

string doTochki = str11.Substring(0, indexTochki).Replace(",", "");
string posleTochki = str11.Substring(indexTochki + 1).Replace("3", "+");

string result11 = doTochki + "." + posleTochki;

Console.WriteLine("Обновлённая строка: " + result11);

////////////////////////////////////////////
///////////////////TASK 12//////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 12(Первенство `d`): ");

string str12 = Console.ReadLine();
int i12 = str12.IndexOf('d');

if (i12 >= 0) 
{
    string result12 = str12.Substring(i12); 
    Console.WriteLine("Обновлённая строка: " + result12);
}
else
{
    Console.WriteLine("Переписывай, я не вижу тут букву `d`.");
}

////////////////////////////////////////////
///////////////////TASK 13//////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 13(Реверс): ");

string str13 = Console.ReadLine();
string[] words13 = str13.Split(' ');

Array.Reverse(words13);
string result13 = string.Join(" ", words13);

Console.WriteLine("Перевёрнутая строка: " + result13);

////////////////////////////////////////////
///////////////////TASK 14//////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 14(Выбрасываем мусор(пробелы)): ");

string str14 = Console.ReadLine();

string result14 = str14.Replace(" ", "");

Console.WriteLine(result14);

////////////////////////////////////////////
///////////////////TASK 15//////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 15(Повторяем гласные и согласные): ");

string str15 = Console.ReadLine();
char lastBukva = str15[str15.Length - 1];

if ("аеёиоуыэюя".Contains(lastBukva))
{
    Console.WriteLine("Слово оканчивается на гласную букву, не на согласную)");
}
else
{
    Console.WriteLine("Слово оканчивается на согласную букву, не на гласную)");
}

////////////////////////////////////////////
///////////////////TASK 16//////////////////
////////////////////////////////////////////

Console.WriteLine("Введите строку к заданию 16(А может нет, а может нет): ");

string str16 = Console.ReadLine();
string[] words16 = str16.Split(new[] { "нет," }, StringSplitOptions.None);
int count16 = words16.Length - 1;


Console.WriteLine($"Слово `нет` встречается {count16} раз.");
