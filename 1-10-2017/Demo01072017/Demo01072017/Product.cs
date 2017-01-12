using System;

namespace Demo01072017
{
    class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Double UnitPrice { get; set; }
        public String UnitOfMeasure { get; set; }
    }

    class ShoppingCartItem
    {        
        public Product MyProduct { get; set; }

        public int Quantity { get; set; }

        //Calculate property
        public Double SubTotal
        {
            get
            {
                return MyProduct.UnitPrice * Quantity;
            }
        }

        //Method
        // = vs ==
        // >, <, >=, <=, ==, !=
        //String name = "";
        //if ( x == yy) // if (x = y)
        //= assignment == logical comparor/operator

        //public Double GetSubTotal()
        //{
        //    return MyProduct.UnitPrice * Quantity;
        //}
    }

    class Customer
    {
    }
}