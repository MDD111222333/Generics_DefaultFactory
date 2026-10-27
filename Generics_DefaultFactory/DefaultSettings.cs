using System;

namespace Generics_DefaultFactory
{
    public class DefaultSettings : IInitializable
    {
        public void Initialize()
        {
            Console.WriteLine("Инициализация DefaultSettings выполнена: загружены стандартные параметры.");
        }
    }
}