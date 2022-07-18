using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static void WriteText()
{
    Console.Write("Введите данные нового сотрудника: ");
    using (StreamWriter sw = new StreamWriter("Сотрудники.txt", true, Encoding.Unicode))
    {
        char key = '1';

        do
        {
            string note = string.Empty;
            Console.Write("\nВведите ID нового работника: ");
            note += $"{Console.ReadLine() + '#'}";

            string now = DateTime.Now.ToShortTimeString();
            Console.WriteLine($"Время и дата записи {now}");
            note += $"{now + '#'}";

            string fullName = string.Empty;
            Console.Write("\nВведите Ф.И.О. нового работника: ");
            note += $"{Console.ReadLine() + '#'}";

            string age = string.Empty;
            Console.Write("\nВведите возраст нового работника: ");
            note += $"{Console.ReadLine() + '#'}";

            string tall = string.Empty;
            Console.Write("\nВведите рост нового работника: ");
            note += $"{Console.ReadLine() + '#'}";

            string dataBirthday = string.Empty;
            Console.Write("\nВведите дату рождения нового работника: ");
            note += $"{Console.ReadLine() + '#'}";

            string birthPlace = string.Empty;
            Console.Write("\nВведите место рождения нового работника: ");
            note += $"{Console.ReadLine() + '#'}";
            sw.WriteLine(note);
            Console.Write("Если хотите добавить еще одного сотрудника, нажмите 1, если нет, то 2."); key = Console.ReadKey(true).KeyChar;
        } while (char.ToLower(key) == '1');
    }

}

static void ReadText()
{
    using (StreamReader sr = new StreamReader("Сотрудники.txt", Encoding.Unicode))
    {
        string line;
        //Console.WriteLine($"{"ID"}{" Время",6} {"ФИО",10} {"Возраст", 11} {" Рост",7} {" Дата Рождения",15} {" Место рождения",12} ");

        while ((line = sr.ReadLine()) != null)
        {

            string[] data = line.Split(new char[] { '#' });

            foreach (string s in data)
            {
                Console.WriteLine(s);

            }
        }
    }
}

Console.WriteLine("Нажмите 1, чтобы вывести данные на экран.");
Console.WriteLine("Нажмите 2, чтобы заполнить данные нового сотрудника и добавить запись в конец файла");

int k = int.Parse(Console.ReadLine());

while (k == 2)
{
    WriteText();
    break;
}

while (k == 1)
{
    ReadText();
    break;
}
