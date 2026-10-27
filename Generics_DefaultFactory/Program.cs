using System;

namespace Generics_DefaultFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Проверка по контрольным ключам ---");

            DefaultUser user = Factory.CreateAndInitialize<DefaultUser>();
            DefaultSettings settings = Factory.CreateAndInitialize<DefaultSettings>();

            Console.WriteLine("\n[Демонстрация ошибки компиляции CS0304 без new()]");
            Console.WriteLine("Если убрать constraint 'new()', строка 'T instance = new T();' вызовет ошибку компиляции CS0304, так как компилятор не знает, имеет ли тип конструктор без параметров.");

            // Закомментированный метод без ограничения new() для демонстрации ошибки CS0304:
            /*
            static T InvalidCreate<T>() where T : IInitializable
            {
                return new T(); // Ошибка CS0304: невозможно создать экземпляр типа переменной 'T', поскольку у него нет ограничения new()
            }
            */

            Console.WriteLine();
            Console.WriteLine("=== Интерактивный режим создания объектов ===");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nВыберите объект для создания:");
                    Console.WriteLine("1 - DefaultUser");
                    Console.WriteLine("2 - DefaultSettings");
                    Console.WriteLine("0 - Выход");
                    Console.Write("Ваш выбор: ");

                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input) || input.Trim() == "0")
                    {
                        break;
                    }

                    if (input.Trim() == "1")
                    {
                        Factory.CreateAndInitialize<DefaultUser>();
                    }
                    else if (input.Trim() == "2")
                    {
                        Factory.CreateAndInitialize<DefaultSettings>();
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: неверный пункт меню.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}