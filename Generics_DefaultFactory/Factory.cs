namespace Generics_DefaultFactory
{
    public class Factory
    {
        public static T CreateAndInitialize<T>() where T : IInitializable, new()
        {
            T instance = new T();
            instance.Initialize();
            return instance;
        }
    }
}