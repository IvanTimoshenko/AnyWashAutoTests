using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages.AdminPages.TransactionsPage
{
    public class TransactionsPage
    {
        public static string TransactionsPageUrl { get; } = "https://anywash.info/newtranss";


        public static Button BtnTransactions { get; } = new Button("//button[@data-toggle='dropdown']");


        public static Button BtnAllDownloadFunctions { get; } = new Button("//div[@class='dropdown-menu']/a");


        public static Button BtnCategoryWashing { get; } = new Button("//nav/a[@data-rb-event-key='washing']");


        public static Button BtnCategoryTires { get; } = new Button("//nav/a[@data-rb-event-key='tires']");


        public static Button BtnAllEditTransactionButtons { get; } = new Button("//tr/td/div/div/a[1]");


        public static Button BtnAllDeleteTransactionButtons { get; } = new Button("//tr/td/div/div/a[last()]");


        public static Element ElPagination { get; } = new Element("//ul[@class='rc-pagination']");
    }
}
