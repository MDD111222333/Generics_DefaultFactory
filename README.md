# C_Sharp_Generics_DefaultFactory

## C#_Generics_DefaultFactory

### Задание «Контрольная точка — Ограничение конструктора new()»

Вариант 1. Фабрика по умолчанию
1. Интерфейс IInitializable { void Initialize(); }.
2. Классы DefaultUser и DefaultSettings : IInitializable, каждый со своим конструктором без параметров и своей реализацией Initialize() (заполняет поля значениями по умолчанию).
3. Обобщённый метод T CreateAndInitialize<T>() where T : IInitializable, new(), создающий объект и вызывающий Initialize().
4. Продемонстрируйте вызов для DefaultUser и DefaultSettings.
5. Продемонстрируйте (закомментированным кодом с пояснением), что без new() строка new T() не компилируется (ошибка CS0304).

Результаты и проверочные ключи:
<img width="1791" height="321" alt="изображение" src="https://github.com/user-attachments/assets/d7039219-d36d-4e30-ae3a-3304ce82f464" />



Результат работы:
<img width="2337" height="783" alt="изображение" src="https://github.com/user-attachments/assets/5da40409-3d0f-4bee-b988-f94f58e249fc" />
