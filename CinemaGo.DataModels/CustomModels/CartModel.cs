using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaGo.DataModels.CustomModels
{
    public class CartModel
    {
        public int UserId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public int AvailableStock { get; set; }

        public int ShippingCharges { get; set; }

        public int SubTotal { get; set; }

        public int Total { get; set; }

        public string ShippingAddress { get; set; }

        public string PaymentMode { get; set; }


        public double PayPalPayment { get; set; }

        public string Stripecard_Number { get; set; }

        public int Stripeexp_Month { get; set; }
    
        public int Stripeexp_Year {get; set; }

        public string Stripe_Cvc { get; set; }

        public decimal Stripe_Value { get; set; }

        public string orderReference { get; set; }



    }
}
