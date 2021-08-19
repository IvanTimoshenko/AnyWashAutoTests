using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Utils
{
    /// <summary> класс, содержащий поля и методы для генерации гос. номера </summary>
    public class CarNumberGenerator
    {
        /// <summary> Список букв для гос. номеров Русского алфавита </summary>
        public static List<char> CarNumberRussianAlphabet { get; } = new List<char>() { 'а', 'А', 'в', 'В', 'е', 'Е', 'к', 'К', 'м', 'М', 'н', 'Н',
            'о', 'О', 'р', 'Р', 'с', 'С', 'т', 'Т', 'у', 'У', 'х', 'Х'};

        /// <summary> Список букв для гос. номеров Английского алфавита </summary>
        public static List<char> CarNumbersEnglishAlphabet { get; } = new List<char>() { 'a', 'A', 'b', 'B', 'c', 'C', 'e', 'E', 'h', 'H', 'k', 'K',
            'm', 'M', 'o', 'O', 'p', 'P', 't', 'T', 'x', 'X', 'y', 'Y'};

        /// <summary> Список цифр </summary>
        public static List<int> CarNumbersIntegers { get; } = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        /// <summary> Типы гос. номеров </summary>
        public static List<string> LicensePlateType { get; } = new List<string>() { "X777XX777", "XX777X777", "XX777777" };


        /// <summary> Длина буквенной части в начале гос. номера </summary>
        public static List<int> FirstLetterLength { get; } = new List<int>() { 1, 2 };

        /// <summary> Длина буквенной части в середине гос. номера </summary>
        public static List<int> SecondLetterLength { get; } = new List<int>() { 1, 2 };

        /// <summary> Длина циферной части гос. номера </summary>
        public static List<int> MiddleNumberLength { get; } = new List<int>() { 3 };

        /// <summary> Длина региона гос. номера </summary>
        public static List<int> RegionLength { get; } = new List<int>() { 2, 3 };
        

        /// <summary> метод для генерации случайного гос. номера </summary>
        /// <returns> гос. номер string </returns>
        public string GetRandomCarNumber()
        {
            string carNumber = "";
            //рандомизируем тип гос. номера
            switch (new Random().Next(1, LicensePlateType.Count + 1))
            {
                //стандартный гос. номер
                case 1:
                    carNumber = StandartPlate();
                    break;
                //транзитный гос. номер
                case 2:
                    carNumber = TransitPlate();
                    break;
                //гос. номер формата Такси
                case 3:
                    carNumber = TaxiPlate();
                    break;
            }
            //проверяем, не совпадает ли сгенерированный номер с номером из БД
            for (int i = 0; i < Config.CarNumbers.Count; i++)
            {
                if (carNumber == Config.CarNumbers[i])
                {
                    GetRandomCarNumber();
                }
            }
            return carNumber;
        }

        /// <summary> Метод для генерации стандартного гос. номера </summary>
        /// <returns> гос. номер string </returns>
        private string StandartPlate()
        {
            List<string> plate = new List<string>();
            //генерируем первые 6 знаков номера
            for (int i = 0; i < 6; i++)
            {
                //добавляем буквы
                if (i == 0 || i == 4 || i == 5)
                {
                    //выбираем язык для буквы 1 - русский, 2 - английский
                    switch (new Randomizer().Randomize(2))
                    {
                        case 1:
                            plate.Add(new Randomizer().GetRandomChar(CarNumberRussianAlphabet).ToString());
                            break;
                        case 2:
                            plate.Add(new Randomizer().GetRandomChar(CarNumbersEnglishAlphabet).ToString());
                            break;
                    }
                    continue;
                }
                ///добавляем цифры
                plate.Add(new Randomizer().GetRandomInt(CarNumbersIntegers).ToString());
                continue;
            }
            //выбираем количество цифр в регионе (2 или 3)
            for (int i = 0; i < new Randomizer().GetRandomInt(RegionLength); i++)
            {
                plate.Add(new Randomizer().GetRandomInt(CarNumbersIntegers).ToString());
            }
            return plate.ToString();
        }

        /// <summary> Метод для генерации транзитного гос. номера </summary>
        /// <returns> гос. номер string </returns>
        private string TransitPlate()
        {
            List<string> plate = new List<string>();
            //генерируем первые 6 знаков гос. номера
            for (int i = 0; i < 6; i++)
            {
                //добавляем буквы
                if (i == 0 || i == 1 || i == 5)
                {
                    //выбираем язык для буквы 1 - русский, 2 - английский
                    switch (new Randomizer().Randomize(2))
                    {
                        case 1:
                            plate.Add(new Randomizer().GetRandomChar(CarNumberRussianAlphabet).ToString());
                            break;
                        case 2:
                            plate.Add(new Randomizer().GetRandomChar(CarNumbersEnglishAlphabet).ToString());
                            break;
                    }
                    continue;
                }
                ///добавляем цифры
                plate.Add(new Randomizer().GetRandomInt(CarNumbersIntegers).ToString());
            }
            //выбираем количество цифр в регионе (2 или 3)
            for (int i = 0; i < new Randomizer().GetRandomInt(RegionLength); i++)
            {
                plate.Add(new Randomizer().GetRandomInt(CarNumbersIntegers).ToString());
            }
            return plate.ToString();
        }

        /// <summary> Метод для генерации гос. номера формата такси </summary>
        /// <returns> гос. номер string </returns>
        private string TaxiPlate()
        {
            var plate = new List<string>();
            //генерируем первые 5 знаков номера
            for (int i = 0; i < 5; i++)
            {
                //добавляем буквы
                if (i == 0 || i == 1)
                {
                    //выбираем язык для буквы 1 - русский, 2 - английский
                    switch (new Randomizer().Randomize(2))
                    {
                        case 1:
                            plate.Add(new Randomizer().GetRandomChar(CarNumberRussianAlphabet).ToString());
                            break;
                        case 2:
                            plate.Add(new Randomizer().GetRandomChar(CarNumbersEnglishAlphabet).ToString());
                            break;
                    }
                    continue;
                }
                ///добавляем цифры
                plate.Add(new Randomizer().GetRandomInt(CarNumbersIntegers).ToString());
                continue;
            }
            //выбираем количество цифр в регионе (2 или 3)
            for (int i = 0; i < new Randomizer().GetRandomInt(RegionLength); i++)
            {
                plate.Add(new Randomizer().GetRandomInt(CarNumbersIntegers).ToString());
            }
            return plate.ToString();
        }

    }
}
