using AnyWashAutotests.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests
{
    public class Randomizer
    {
        Random random = new Random();

        /// <summary> Метод для получения случайного гос. номера </summary>
        /// <param name="list"> Список гос. номеров машин </param>
        /// <returns> гос. номер (string) </returns>
        public string GetRandomCarNumber(List<string> list)
        {
            return list[random.Next(0, list.Count - 1)];
        }

        /// <summary> Метод для получения случайного типа услуги </summary>
        /// <param name="list"> Список доступных услуг </param>
        /// <returns> индекс типа услуги </returns>
        public int GetRandomWashMode(List<IWebElement> list)
        {
            return random.Next(1, list.Count);
        }

        /// <summary> Метод для получения случайной char </summary>
        /// <param name="list"> Список char </param>
        /// <returns> случайная char </returns>
        public char GetRandomChar(List<char> list)
        {
            return list[random.Next(0, list.Count - 1)];
        }

        /// <summary> Метод для получения случайной int </summary>
        /// <param name="list"> Список int </param>
        /// <returns> случайная int </returns>
        public int GetRandomInt(List<int> list)
        {
            return list[random.Next(0, list.Count - 1)];
        }

        /// <summary> метод для получения случайной int (от 1) </summary>
        /// <param name="num"> максимальное значение </param>
        /// <returns> случайная int </returns>
        public int Randomize(int num)
        {
            return random.Next(1, num);
        }
    }
}
