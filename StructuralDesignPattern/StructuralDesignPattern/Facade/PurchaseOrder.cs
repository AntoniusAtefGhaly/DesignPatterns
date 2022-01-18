namespace Facade
{
    public class PurchaseOrder
    {
        public bool CreateOrder(ShoppingBasket basket, string custInfo)
        {
            #region facade

            //check stock
            bool isAvailable = true;
            Inventory inventory = new Inventory();
            foreach (BasketItem item in basket.GetItems())
            {
                if (!inventory.CheckItemQuantity(item.ItemID, item.Quantity))
                {
                    isAvailable = false;
                }
            }
            if (isAvailable)
            {
                //create inventory order
                InventoryOrder inventoryOrder = new InventoryOrder();
                inventoryOrder.CreateOrder(basket, "1");

                //create inovice
                PurchaseInvoice invoice = new PurchaseInvoice();
                var inv = invoice.CreateInvoce(basket, custInfo);

                //payment
                PaymentProcessor payment = new PaymentProcessor();
                payment.HandlePayment(inv.netTotal, "cib1238535");

                //send SMS
                SmsNotifications sms = new SmsNotifications();
                sms.SendSms("123", "invoice created");

                return true;
            }
            else
                return false;
            #endregion

        }
    }
}