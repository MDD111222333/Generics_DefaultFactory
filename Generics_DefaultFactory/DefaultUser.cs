using System;

namespace Generics_DefaultFactory
{
    public class DefaultUser : IInitializable
    {
        public void Initialize()
        {
            Console.WriteLine("Инициализация DefaultUser выполнена: заполнены поля по умолчанию.");
        }
    }
}