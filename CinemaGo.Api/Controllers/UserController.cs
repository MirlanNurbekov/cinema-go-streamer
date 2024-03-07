using CinemaGo.DataModels.CustomModels;
using CinemaGo.Logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaGo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly IUserService _userService;

        public UserController(IUserService userService )
        {
            this._userService = userService;
            
        }
        [HttpGet]
        [Route("GetCategories")]

        public IActionResult GetCategories()
        {
            var data = _userService.GetCategories();
            return Ok(data);
        }
        [HttpGet]
        [Route("GetProducts")]

        public IActionResult GetProducts()
        {
            var data = _userService.GetProducts();
            return Ok(data);
        }

        [HttpGet]
        [Route("GetProductByCategoryId")]

        public IActionResult GetProductByCategoryId(int categoryId) 
        {
            var data = _userService.GetProductByCategoryId(categoryId); 
            return Ok(data);
        }

        [HttpPost]
        [Route("RegisterUser")]
        public IActionResult RegisterUser(RegisterModel registerModel) 
        {
            var data = _userService.RegisterUser(registerModel); 
            return Ok(data);
        }

        [HttpPost]
        [Route("LoginUser")]
        public IActionResult LoginUser(LoginModel loginModel)
        {
            var data = _userService.LoginUser(loginModel);
            return Ok(data);
        }

        [HttpPost]
        [Route("SaveContactUs")]

        public IActionResult SaveContactUs(ContactUsModel newContactUs)
        {
            var data = _userService.SaveContactUs(newContactUs);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetContactUs")]

        public IActionResult GetContactUss()
        {
            var data = _userService.GetContactUss();
            return Ok(data);
        }

        [HttpPost]
        [Route("DeleteContactUs")]

        public IActionResult DeleteContactUs(ContactUsModel contactusToDelete)
        {
            var data = _userService.DeleteContactUs(contactusToDelete);
            return Ok(data);
        }



        [HttpGet]
        [Route("GetOrdersByCustomerId")]

        public IActionResult GetOrdersByCustomerId(int CustomerId) 
        {
            var data = _userService.GetOrdersByCustomerId(CustomerId);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetOrderDetailForCustomer")]

        public IActionResult GetOrderDetailForCustomer(int CustomerId, string order_number)
        {
            var data = _userService.GetOrderDetailForCustomer(CustomerId, order_number);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetShippingStatusForOrder")]

        public IActionResult GetShippingStatusForOrder(string order_number) 
        {
            var data = _userService.GetShippingStatusForOrder(order_number);
            return Ok(data);
        }

        [HttpPost]
        [Route("ChangePassword")]

        public IActionResult ChangePassword(PasswordModel passwordModel)
        {
            var data = _userService.ChangePassword(passwordModel);
            return Ok(data);
        }

        [HttpGet]
        [Route("CheckoutStripe")]

        public IActionResult CheckoutStripe(string cardNumber, int expMonth, int expYear, string cvc, decimal value)
        {
            var data = _userService.MakePaymentStripe(cardNumber, expMonth, expYear, cvc, value);
            return Ok(data);
        }

        [HttpGet]
        [Route("CheckoutPayPal")]

        public async Task<IActionResult> CheckoutPayPal (double total)
        {
            var url = await _userService.MakePaymentPaypal(total);
            return Ok(url);
        }

        [HttpPost]
        [Route("Checkout")]

        public async Task <IActionResult> Checkout(List<CartModel> cartItems)
        {
            ResponseModel responseModel = new ResponseModel();
            var record = cartItems.FirstOrDefault();
            if (record != null) 
            {

                if(record.PaymentMode == "CashOnDelivery") 
                {
                    responseModel = _userService.Checkout(cartItems);
                }
                if(record.PaymentMode == "PayPal")
                {
                    var data = _userService.MakePaymentPaypal(record.PayPalPayment);
                    if (data != null) 
                    {
                        var ref_number = data.Result.Split("&")[1];
                        cartItems.FirstOrDefault().orderReference = ref_number.Split("=")[1];
                        responseModel = _userService.Checkout(cartItems);
                    }
                    
                }
                if (record.PaymentMode== "Stripe") 
                {
                    var data = await _userService.MakePaymentStripe(record.Stripecard_Number, record.Stripeexp_Month, record.Stripeexp_Year,record.Stripe_Cvc,record.Stripe_Value);
                    if (data != null && data.Contains("Success")) 
                    {
                        cartItems.FirstOrDefault().orderReference = data.Split("=")[1];
                        responseModel = _userService.Checkout(cartItems);
                    }
                }
            }
            return Ok(responseModel);

            //var data = _userService.Checkout(cartItems);
            //return Ok(data);
        }
    }
    
}