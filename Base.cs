using System;
using System.Collections.Generic;
using System.Linq;

namespace JustCode
{
    class Info
    {
        public string[] name = {"Pol", "Maik", "Rustam"};
        public string[] number = new string[] {"8947381193", "8932104241", "8943298743"};
        public string[] where_life = new string[] {"г.Ульяновск", "г.Москва", "г.Самара"};
    }
    class Look : Info
    {
        public void MasInfo()
        {
            bool answer_2 = true;
            while (answer_2 == true)
            {
                if (name.Length != 0)
                {
                    if (name.Length == 0)
                    {
                        Console.WriteLine("Массив пустой!");
                        answer_2 = false;
                        continue;
                    }
                    for (int i = 0; i < name.Length; i++)
                        Console.Write($"{name[i]} ");
                    Console.Write("\nВведите имя для подробной информации:");
                    string special_name = Console.ReadLine();
                    bool check = false;
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (special_name == name[i])
                        {
                            Console.WriteLine($"Имя = {name[i]};\nМесто жительства = {where_life[i]};\nНомер телефона = {number[i]};");
                            check = true;
                        }
                    }
                      if(check == false)
                        Console.WriteLine("Not Found!");
                    /*if (rez_check == true)
                    {
                        string ans_3;
                        Modern repMas = new Modern();
                        Console.Write("Желаете внести изменения?\nY-да;N-нет;\nВаш ответ: ");
                        ans_3 = Console.ReadLine();
                        if (ans_3 == "Y" || ans_3 == "y")
                            repMas.remMas();
                    }*/
                    Console.Write("Желаете продолжить?\nY-да; N-нет\nВаш ответ: ");
                    string ans = Console.ReadLine();
                    if (ans == "y" || ans == "Y")
                    {
                        answer_2 = true;
                        Console.Clear();
                    }
                    else
                        answer_2 = false;
                }
            }
        }
    }
    class Modern : Info
    {
        public void remMas()
        {
            string answer = "y";
            while (answer == "y")
            {
                bool check = false;
                string name_persen = "";
                Console.Write("Выбирите дальнейшие действия:\n1-изменить;\n2-удалить;\n3-добавить;\nВаш выбор:");
                int y = Convert.ToInt32(Console.ReadLine());
                List<string> new_name, new_life, new_number = new List<string>();
                new_name = name.ToList();
                new_life = where_life.ToList();
                new_number = number.ToList();
                switch (y)
                {
                    case 1:
                        if (name.Length != 0)
                        {
                            for (int a = 0; a < name.Length; a++)
                                Console.Write($"{name[a]} ");
                            Console.Write("Ваш выбор: ");
                            name_persen = Console.ReadLine();
                            for (int i = 0; i < name.Length; i++)
                            {
                                if (name_persen == name[i])
                                {
                                    Console.Write("Введите новое имя = ");
                                    new_name[i] = Console.ReadLine();
                                    Console.Write("Введите новое место жительство = ");
                                    new_life[i] = Console.ReadLine();
                                    Console.Write("Введите новый телефон = ");
                                    new_number[i] = Console.ReadLine();
                                    check = true;
                                }
                            }
                        }
                        if (check == false)
                            Console.WriteLine("Элемент отсутствует.");
                        if (name.Length == 0)
                            Console.WriteLine("Массив пустой!");
                        check = false;
                        break;
                    case 2:
                        if (name.Length != 0)
                        {
                            for (int a = 0; a < name.Length; a++)
                                Console.Write($"{name[a]} ");
                            Console.Write("\nВаш выбор: ");
                            name_persen = Console.ReadLine();
                            for (int i = 0; i < name.Length; i++)
                            {
                                if (name_persen == name[i])
                                {
                                    new_name.RemoveAt(i);
                                    new_life.RemoveAt(i);
                                    new_number.RemoveAt(i);
                                    check = true;
                                }
                            }
                        }
                        if (check == false)
                            Console.WriteLine("Элемент отсутствует.");
                        if (name.Length == 0)
                            Console.WriteLine("Массив пустой!");
                        check = false;
                        break;
                    case 3:
                        Console.WriteLine("Введите нового клиента:");
                        Console.Write("Имя: ");
                        new_name.Add(Console.ReadLine());
                        Console.Write("Место жительства: ");
                        new_life.Add(Console.ReadLine());
                        Console.Write("Номер телефона: ");
                        new_number.Add(Console.ReadLine());
                        break;
                }
                where_life = new_life.ToArray();
                name = new_name.ToArray();
                number = new_number.ToArray();
                Console.Write("Желаете продолжить(y - да; n - нет): ");
                answer = Console.ReadLine();
                Console.Clear();
            }
        }
    }
    class Prov
    {
        public bool Pass(string password, bool rez, string login)
        {
            string[] lg = new string[2] { "admin", "Kazizahn" };
            string[] pasw = new string[2] { "1234", "12345" };
            for (int i = 0; i < 2; ++i)
            {
                rez = ((login == lg[i]) && (password == pasw[i]));
                if (rez == true)
                {
                    Console.Clear();
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Администратор или гость?: ");
            Prov safe = new Prov();
            Look see_mas = new Look();
            Modern change_mas = new Modern();
            string who_open = Console.ReadLine();
            string login, password;
            bool rez = false;
            if (who_open == "Администратор" || who_open == "администратор")
            {
                while (rez == false)
                {
                    Console.Write("Введите логин:");
                    login = Console.ReadLine();
                    Console.Write("Введите пароль:");
                    password = Console.ReadLine();
                    rez = safe.Pass(password, rez, login);
                    if (rez == false)
                        Console.WriteLine("Неправильно введен логин или пароль.");
                }
                Console.Write($"Выберите дальнейшие действия(1 - просмотреть массив; 2 - изменить массив):");
                int dei = Convert.ToInt32(Console.ReadLine());
                while ((dei != 1) && (dei != 2))
                {
                    Console.WriteLine("Выбран вариант выходящий за возможности");
                    Console.Write("\nВыберите дальнейшие действия:");
                    dei = Convert.ToInt32(Console.ReadLine());
                }
                switch (dei)
                {
                    case 1:
                        see_mas.MasInfo();
                        break;
                    case 2:
                        change_mas.remMas();
                        break;
                }
            }
            else if (who_open == "Гость" || who_open == "гость")
                see_mas.MasInfo();
            else 
                Console.WriteLine("Not Found.");
            Console.ReadKey();
        }
    }
}