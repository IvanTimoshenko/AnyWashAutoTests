using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages
{
    /// <summary>
    /// Класс Page Object - Транзакции мойка
    /// </summary>
    public class CarWashTransactionsPage
    {
        /// <summary> Елемент с таблицей транзакций </summary>
        public static Element ElTransactionsTable = new Element("//table//th");
    }
}
