using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages.AdminPages.DriversPage
{
    public class CreateOrEditDriverPage
    {
        public static string EditDriverPageUrl = "https://anywash.info/drivers/add/";


        public static Input InputName { get; } = new Input("//input[@id='name']");


        public static Input InputPhoneNumber { get; } = new Input("//input[@id='phone']");


        public static Select SelectCompany { get; } = new Select("//select[@id='company_id']");


        public static string OptionsOfCompany { get; } = "//select[@id='company_id']/option";
    }
}
