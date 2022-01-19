using System;

namespace Facade // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create basket
            ShoppingBasket basket = new ShoppingBasket();

            basket.AddItem(new BasketItem()
            {
                ItemID = "123",
                ItemPrice = 200,
                Quantity = 5
            });
            basket.AddItem(new BasketItem()
            {
                ItemID = "123",
                ItemPrice = 200,
                Quantity = 5
            });
            PurchaseOrder purchaseOrder = new PurchaseOrder();
            purchaseOrder.CreateOrder(basket,"cus:ant,add:cairo");
        }
    }
}