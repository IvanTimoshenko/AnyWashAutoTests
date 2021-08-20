using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Utils
{
    /// <summary> Класс для формирования невалидного гос. номера </summary>
    public class CarNumberCrasher
    {
        /// <summary> Список невалидных символов </summary>
        public static List<char> Symbols { get; } = new List<char>() { '!', '#', '$', '%', '&', '‘', '*', '+', '—', '/', '=', '?', '^', '_', '`', '{', '|', '}', '~' };

        /// <summary> Пробел </summary>
        public static char SpaceBar { get; } = ' ';


        public string CrashCarNumber(string carNumber)
        {
            string plate = "X777XX777";
            var a = plate.ToCharArray();
            var charOrInt = new List<char>();
            char _int = '0';  //показатель типа int
            char _char = '1'; //показатель типа char
            string crachedPlate = string.Empty;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < CarNumbersIntegers.Count; j++)
                {
                    if (a[i] == CarNumbersIntegers[j])
                    {
                        charOrInt.Add(_int);
                    }

                }
                for (int c = 0; c < CarNumbersEnglishAlphabet.Count; c++)
                {
                    if (a[i] == CarNumberRussianAlphabet[c] || a[i] == CarNumbersEnglishAlphabet[c])
                    {
                        charOrInt.Add(_char);
                    }
                }
            }

            for (int i = 0; i < charOrInt.Count; i++)
            {
                if (new Random().Next(0, 5) == 2) //шанс замены - 20%
                {
                    charOrInt[i] = new Randomizer().GetRandomChar(Symbols);
                    continue;
                }
                charOrInt[i] = a[i];

            }
            if (string.Join("", charOrInt) == plate)
            {
                continue;
            }
            Console.WriteLine($" {z + 1})  {string.Join("", charOrInt)}");
        }
    }
}
