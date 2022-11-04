using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    //главный
    public class Борис { }

    //финансовый директор(Рашид)
    class Рашид : Борис { } 
    class Лукас : Рашид { }
    class Бухгалтерия : Лукас { }

    // директор по автоматизации:
    class Оильхам : Борис { } 
    class Оркадий : Оильхам { }
    class Володя : Оркадий { }

    // системщики
    class Ильшат : Володя { } 
    class Иваныч : Ильшат { }
    class Илья : Иваныч { }
    class Витя : Иваныч { }
    class Женя : Иваныч { }
    
    // разработчики
    class Сергей : Володя { }
    class Ляйсан : Сергей { }
    class Марат : Ляйсан { }
    class Дина : Ляйсан { }
    class Ильдар : Ляйсан { }
    class Антон : Ляйсан { }
    internal class Program
    {
        static void Otvet(Type a, Type b)
        {
            if (a.IsSubclassOf(b)) { Console.WriteLine("Да, господин"); } // проверяем является ли классы наследниками друг друга
            else { Console.WriteLine("Нет, пошёл ты"); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите от кого хотите дать задачу");
            string A1 = Console.ReadLine();
            Console.WriteLine("Введите кому хотите дать задачу");
            string B1 = Console.ReadLine();
            Console.WriteLine("Введите название задачи");
            string C1 = Console.ReadLine();
            Type A = Type.GetType("HW" + "." + A1, false, true); // получаем типы классов по имени
            Type B = Type.GetType("HW" + "." + B1, false, true);
            Console.WriteLine($"Итак, от {A1} дана задача {C1}  для {B1}.");
            Console.WriteLine("Ответ сотрудника:");
            Otvet(B, A);
        }
    }
}
