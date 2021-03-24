using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SPOS.Models;
using System;
using System.Collections.Generic;

namespace SPOS.Pages
{
    public class PaymentModel : PageModel
    {
        [BindProperty]
        public string CashReceived { get; set; }
        [BindProperty]
        public string Total { get; set; }
        [BindProperty]
        public string ReceiptContents { get; set; }
        [BindProperty]
        public string PaymentMethod { get; set; }
        [BindProperty]
        public string DiscountApplied { get; set; }
        [BindProperty]
        public bool ModifyOrder { get; set; }
        [BindProperty]
        public string SelectedOrder { get; set; }

        List<Receipt> receipt = new List<Receipt>();
        public void insertItemsInReceipt(int receipt_id)
        {
            foreach (var item in receipt)
            {
                Requests.Requests.insertItemInOrder(receipt_id, int.Parse(item.id), int.Parse(item.qty));
            }
        }
        public ActionResult OnGet(){
            try
            {
                int.Parse(HttpContext.Session.GetString("userId"));
            }
            catch (Exception e)
            {
                return Redirect("/");
            }
            return Page();
        }

        public ActionResult OnPost()
        {
            if (String.IsNullOrEmpty(DiscountApplied)) DiscountApplied = "0";

            //receive order from ui
            receipt = JsonConvert.DeserializeObject<List<Receipt>>(ReceiptContents);

            if (ModifyOrder)
            {
                //update columns of the existing order 

                Requests.Requests.modifyReceipt(SelectedOrder, PaymentMethod, int.Parse(DiscountApplied));

                //delete all items inside items_receipt that are in that orderid (deleteReceiptContents)
                Requests.Requests.removeReceiptContents(SelectedOrder);

                insertItemsInReceipt(int.Parse(SelectedOrder)); //re-write them again
            }
            else
            {
                double change = 0;
                if (PaymentMethod.Equals("CASH"))
                {
                    change = double.Parse(CashReceived) - double.Parse(Total);
                    //if the change is a negative number, something is wrong, so return same page and refuse to close the order
                    if (change < 0) return Page();
                }
                HttpContext.Session.SetString("change", change.ToString());

                //create order in database
                int receipt_id = Requests.Requests.CreateOrder(int.Parse(HttpContext.Session.GetString("userId")), PaymentMethod, int.Parse(DiscountApplied));

                insertItemsInReceipt(receipt_id);
            }
            //redirect to page to display the change(money)
            return Redirect("./EndPage"); //move to endpage
        }
    }
}
