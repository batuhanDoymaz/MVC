using System;

namespace MVC_Odev.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipAdress { get; set; }



        //Failed to work - Has to be written in javascript
        public static string DeleteById(int id)
        {
            foreach (var item in Program.orders)
            {
                if (item.Id == id)
                {
                    Program.orders.Remove(item);
                    return "Success";
                }
            }
            return "Failed";

        }
    }
}
