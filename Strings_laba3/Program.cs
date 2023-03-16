using System.Runtime.InteropServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
////////////////////////////////////////////
///////////////////TASK 1///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 1(Проверка кол-во - Н): ");

string a = Console.ReadLine();
int count1 = 0;
int i1 = 0;
int len1 = a.Length;

while (i1 < len1)
{
    if (a[i1] == 'Н') count1++;
    i1++;
}

Console.WriteLine(count1);

////////////////////////////////////////////
///////////////////TASK 2///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 2(Удаление слов на с): ");

string b = Console.ReadLine();
string[] words2 = b.Split(" ");

StringBuilder result2 = new StringBuilder();

foreach (string word in words2)
{
    if (!word.StartsWith("с"))    
    {
        result2.Append(word + " ");
    }
}

Console.WriteLine(result2.ToString().Trim());

////////////////////////////////////////////
///////////////////TASK 3///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 3(Вывод слов содержащих хотя бы одну - d): ");

string c = Console.ReadLine();
string[] words3 = c.Split(" ");

foreach (string word in words3)
{
    if (word.Contains("d"))  
    {
        Console.WriteLine(word);
    }
}

////////////////////////////////////////////
///////////////////TASK 4///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 4(Удваивает кол-во букв): ");

string d = Console.ReadLine();
StringBuilder result4 = new StringBuilder();

foreach (char letter in d)
{
    result4.Append(letter.ToString() + letter.ToString());
}

Console.WriteLine(result4.ToString());

////////////////////////////////////////////
///////////////////TASK 5///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 5(Проверяет одинакова ли длина слов в строке): ");

string e = Console.ReadLine();
string[] words5 = e.Split(" ");

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

Console.WriteLine("Введите слово к заданию 6(Объединяет две строки и считает кол-во - da в строке): ");

string f1 = Console.ReadLine();
string f2 = Console.ReadLine();

string f = f1 + " " + f2;

int count6 = 0;

for (int i = 0; i < f.Length - 1; i++)
{
    if (f.Substring(i, 2) == "da")
    {
        count6++;
    }
}

Console.WriteLine("Комбинированная строка: " + f);
Console.WriteLine("Количество раз, когда появляется 'da', равно: " + count6);

////////////////////////////////////////////
///////////////////TASK 7///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 7(Находит самое длинное слово и ставит его в начало): ");

string g = Console.ReadLine();
string[] words7 = g.Split(' ');
string longestWord = "";

foreach (string word in words7)
{
    if (word.Length > longestWord.Length)
    {
        longestWord = word;
    }
}

g = longestWord + " " + g.Replace(longestWord, "");

Console.WriteLine("Обновленная строка: " + g);

////////////////////////////////////////////
///////////////////TASK 8///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 8(Кол-во букв 'y' стоящих на чётных местах): ");

string h = Console.ReadLine();
int count8 = 0;

for (int i = 0; i < h.Length; i += 2)
{
    if (h[i] == 'y')
    {
        count8++;
    }
}

Console.WriteLine("Количество букв 'y' на чётных местах равно: " + count8);

////////////////////////////////////////////
///////////////////TASK 9///////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 9(Меняет все 'a' на 'A'): ");

string j = Console.ReadLine();
string updJ = j.Replace('a', 'A');

Console.WriteLine("Обновлённая строка:" + updJ);



////////////////////////////////////////////
///////////////////TASK 10//////////////////
////////////////////////////////////////////

Console.WriteLine("Введите слово к заданию 10(Определяет первая или последняя буква встречается чаще): ");

string k = Console.ReadLine();

int k1 = 0;
int k2 = 0;

for (int i = 0; i < k.Length; i++)
{
    if (k[i] == k[0])
    {
        k1++;
    }
    if (k[i] == k[k.Length - 1])
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
