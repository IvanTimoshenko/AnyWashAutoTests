using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages.AdminPages.DriversPage
{
    public class DriversPage
    {
        public static string CurrentUrl { get; } = "https://anywash.info/drivers";


        public static Button BtnCreateDriver { get; } = new Button("//div/a[@href='/drivers/add/']");


        public static Button BtnDownloadExcel { get; } = new Button("//div/a[@href='https://api.anywash.info/api/drivers/xslt']");


        public static Button BtnAllEditDriverButtons { get; } = new Button("//tr/td/a[@title='Редактировать']");


        public static Button BtnAllDeleteDriverButtons { get; } = new Button("//tr/td/a[@title='Удалить']");
    }
}
