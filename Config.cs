using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests
{
    class Config
    {
        /// <summary> Ожидания элемента по умолчанию </summary>
        public static TimeSpan WebDriverWait { get; set; } = TimeSpan.FromSeconds(20);
        /// <summary> Логин тестовой мойки </summary>
        public static string PartnerLogin { get; } = "test@anywash.ru";
        /// <summary> Пароль тестовой мойки </summary>
        public static string PartnerPassword { get; } = "123";

        /// <summary> Список тестовых номеров машин </summary>
        public static List<string> CarNumbers { get; } = new List<string>() { "C123CC123", "XX777X777", "XX777797" };

        
    }
}
