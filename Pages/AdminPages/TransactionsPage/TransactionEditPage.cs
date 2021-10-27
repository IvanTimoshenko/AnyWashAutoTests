using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages.AdminPages.TransactionsPage
{
    public class TransactionEditPage
    {
        public static Input InputCarPlate { get; } = new Input("//input[@id='number']");


        public static Input InputCarClass { get; } = new Input("//input[@id='class']");


        public static Select SelectCompanyId { get; } = new Select("//select[@id='company_id']");


        public static Element ElOptionsOfCompanyId { get; } = new Element("//select[@id='company_id']/option");


        public static Select SelectBodyType { get; } = new Select("//select[@id='form_factor']");


        public static Element ElOptionsOfBodyType { get; } = new Element("//select[@id='form_factor']/option");


        public static Input InputDriverId { get; } = new Input("//input[@id='driver_id']");


        public static Input InputDriverName { get; } = new Input("//input[@id='driver_name']");


        public static Input InputClientPrice { get; } = new Input("//input[@id='client_price']");


        public static Input InputPartnerPrice { get; } = new Input("//input[@id='provider_price']");


        public static Select SelectServiceType { get; } = new Select("//select[@id='modeSelect']");


        public static Element ElOptionsOfServiceTypes { get; } = new Element("//select[@id='modeSelect']/option");


        public static Select SelectCategoryOfService { get; } = new Select("//select[@id='category']");


        public static Element ElOptionsCategoryOfServices { get; } = new Element("//select[@id='category']/option");


        public static Select SelectPartnerId { get; } = new Select("//select[@id='washer_company_id']");


        public static Element ElOptionsPartnerId { get; } = new Element("//select[@id='washer_company_id']/option");


        public static Input InputUserId { get; } = new Input("//input[@id='washer_id']");


        public static Input InputCoupon { get; } = new Input("//input[@id='coupon']");


        public static Input InputWheelRadius { get; } = new Input("//input[@id='wheelsize']");


        public static Input InputWheelCount { get; } = new Input("//input[@id='amount']");
    }
}
