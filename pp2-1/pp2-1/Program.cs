using System;
using System.Collections.Generic;
struct Buyer
{
    public int Number;
    public string FullName;
    public string Address;
    public DateTime RegistrationDate;
}
class Program
{
    static void Main()
    {
        List<Buyer> buyers = new List<Buyer>();

        // Добавим несколько покупателей для примера
        buyers.Add(new Buyer { Number = 1, FullName = "Иванов Иван Иванович", Address = "ул. Пушкина, д.10", RegistrationDate = new DateTime(2022, 4, 15) });
        buyers.Add(new Buyer { Number = 2, FullName = "Петров Петр Петрович", Address = "ул. Ленина, д.5", RegistrationDate = new DateTime(2022, 4, 3) });
        buyers.Add(new Buyer { Number = 3, FullName = "Сидоров Сидор Сидорович", Address = "пр. Гагарина, д.3", RegistrationDate = new DateTime(2022, 4, 18) });
        // Сортируем список покупателей по дате постановки на учет
        buyers.Sort((x, y) => x.RegistrationDate.CompareTo(y.RegistrationDate));
        // Выводим список покупателей в порядке очереди по датам постановки на учет
        Console.WriteLine("Список покупателей в порядке очереди по датам постановки на учет:");
        foreach (var buyer in buyers)
        {
            Console.WriteLine($"Покупатель {buyer.Number}: {buyer.FullName}, Адрес: {buyer.Address}, Дата постановки на учет: {buyer.RegistrationDate:dd.MM.yyyy}");
        }
    }
}