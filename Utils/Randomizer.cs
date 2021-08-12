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
        /// <returns> тип услуги (string) </returns>
        public string GetRandomWashMode(List<string> list)
        {
            return list[random.Next(0, list.Count - 1)];
        }
    }
}
