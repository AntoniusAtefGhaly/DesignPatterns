using System;

namespace Facade // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region facade
            //create basket
            ShoppingBasket basket = new ShoppingBasket();
            BasketItem item = new BasketItem()
            {
                ItemID = "123",
                ItemPrice = 200,
                Quantity = 5
            };
            //check stock
            Inventory inventory = new Inventory();
            if (inventory.CheckItemQuantity(item.ItemID, item.Quantity))
            {
                basket.AddItem(item);
            }
            //create inventory order
            InventoryOrder inventoryOrder= new InventoryOrder();
            inventoryOrder.CreateOrder(basket,"1");

            //create inovice
            PurchaseInvoice invoice = new PurchaseInvoice();
            var inv = invoice.CreateInvoce(basket, "address:123,name :custmer");
            
            //payment
            PaymentProcessor payment = new PaymentProcessor();
            payment.HandlePayment(inv.netTotal, "cib1238535");
            
            //send SMS
            SmsNotifications sms = new SmsNotifications();
            sms.SendSms("123", "invoice created");
            #endregion
        }
    }
}