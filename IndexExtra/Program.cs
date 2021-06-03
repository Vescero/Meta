using System;

namespace IndexExtra
{
    class Program
    {
        static void Main()
        {
            Dictionary dict = new Dictionary();
            Console.WriteLine(dict["blue"]);
            dict["blue"] = "голубой";
            Console.WriteLine(dict["blue"]);
        }
    }
    /* Класс word представляет слово */
    class Word
    {
        public string Source { get; }       // Значение слова
        public string Target { get; set; }  // Перевод слова
        public Word (string source, string target)  // Добавление нового слова
        {
            Source = source;
            Target = target;
        }
    }
    /* Класс Dictionary представляет словарь */
    class Dictionary
    {
        Word[] words;   // Массив слов
        public Dictionary() // Конструктор словаря в котором по умолчанию будут находится
        {
            words = new Word[]  // слова из массива созданного в классе
            {
                new Word ("red", "Красный"),    // Объявление объекта класса word 
                new Word ("blue", "Синий"),
                new Word ("green", "Зеленый")
            };
        }

        public string this[string source]
        {
            get 
            {
                Word word = null;
                foreach (Word w in words)
                {
                    if (w.Source == source)
                    {
                        word = w;
                        break;
                    }               
                }
                return word?.Target;
            }
            set 
            { 
                foreach (Word w in words)
                {
                    if (w.Source == source)
                    {
                        w.Target = value;
                        break;
                    }
                }
            }
        }
    }
}
