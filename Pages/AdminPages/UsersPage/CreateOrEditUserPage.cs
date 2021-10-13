using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages.AdminPages.UsersPage
{
    public class CreateOrEditUserPage
    {
        public static string CreatePageUrl { get; } = "https://anywash.info/add/";


        public static Input InputName { get; } = new Input("//input[@id='name']");


        public static Select SelectRoleOfUser { get; } = new Select("//select[@id='roles']");


        public static string OptionsOfRole { get; } = "//select[@id='roles']/option";


        public static Input InputPhoneNumber { get; } = new Input("//input[@id='phone']");


        public static Input InputEmailAdress { get; } = new Input("//input[@id='email']");


        public static Input InputPassword { get; } = new Input("//input[@id='password']");


        public static Select SelectCompany { get; } = new Select("//select[@id='company_id']");


        public static string OptionsOfCompany { get; } = "//select[@id='company_id']/option";

    }
}
