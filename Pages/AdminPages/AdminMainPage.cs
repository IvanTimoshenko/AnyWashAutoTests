using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages.AdminPages
{
    public class AdminMainPage
    {
        public static Button BtnMainPageLogo { get; } = new Button("//nav/a[@href='//anywash.ru']");

        
        public static Button BtnCategoryUsers { get; } = new Button("//ul/li/a[@href='/users']");


        public static Button BtnCategoryDrivers { get; } = new Button("//ul/li/a[@href='/drivers']");


        public static Button BtnCategoryTransactions { get; } = new Button("//ul/li/a[@href='/newtranss']");


        public static Button BtnCategoryMaintanance { get; } = new Button("//ul/li/a[@href='/maintenance']");


        public static Button BtnCategoryWashers { get; } = new Button("//ul/li/a[@href='/washers']");


        public static Button BtnCategoryCompanies { get; } = new Button("//ul/li/a[@href='/companies']");


        public static Button BtnCategoryCars { get; } = new Button("//ul/li/a[@href='/cars']");


        public static Button BtnCategoryCoupons { get; } = new Button("//ul/li/a[@href='/coupons']");


        public static Button BtnLogOut { get; } = new Button("//ul/li/a[@href='/']");
    }
}
