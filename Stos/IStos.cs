namespace Stos
{
    /// <summary>
    /// Interfejs stosu (generyczny)
    /// </summary>
    /// <remarks>
    /// Założenia:
    /// 1. Po utworzeniu stos jest pusty
    /// 2. Stos jest pojemnikiem o nieograniczonej pojemności
    /// 3. Próba zdjęcia lub odczytania szczytowego elementu ze stosu pustego zgłasza wyjątek
    /// 4. Push oraz Pop są czynnościami wzajemnie odwrotnymi
    /// Dodatkowe:
    /// Stos można przeglądać bez możliwości zmiany elementów (read-only)
    /// </remarks>
    /// <typeparam name="T">dowolny typ wartościowy lub referencyjny</typeparam>
    public interface IStos<T>
    {
        //w interfejsie nie deklaruje się konstruktora

        //wstawia element typu T na stos
        void Push(T value);

        //zwraca szczytowy element stosu
        T Peek { get; }

        //zdejmuje szczytowy element ze stosu
        T Pop();

        //zwraca liczbę elementów na stosie
        int Count { get; }

        //zwraca true, jeśli stos jest pusty, a false w przeciwnym przypadku
        bool IsEmpty { get; }

        //opróżnia stos
        void Clear();

        //kopiuje i eksportuje stos do tablicy
        T[] ToArray();
    }
}
