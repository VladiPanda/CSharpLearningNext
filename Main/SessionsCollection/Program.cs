using System;
using System.Collections.Generic;

/* Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и 
количество дней в соответствующем месяце. Реализуйте возможность выбора месяцев, как по 
порядковому номеру, так и количеству дней в месяце, при этом результатом может быть не 
только один месяц */

namespace SessionsCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<DateTime, List<int>> Months;
            Months.Add(DateTime.DaysInMonth(2021, 1), 1);
            
        }
    }
}