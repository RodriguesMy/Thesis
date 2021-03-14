using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPOS.Classes;
using SPOS.Models;

namespace SPOS.Pages
{
    public class MainPageModel : PageModel
    {
        List<ItemType> itemTypes = new List<ItemType>();
        List<ItemCategory> itemCategories = new List<ItemCategory>();
        public string HtmlContext;

        [BindProperty]
        public String CategorySelection { get; set; }

        public void OnGet()
        {
            //validate user
            itemTypes = Requests.Requests.GetItemTypes();
            itemCategories = Requests.Requests.GetItemCategories();

            //firstly display the categories
            HtmlContext = GenerateHTMLContext.GenerateMenuHTMLContextForCategoriesAndTypes(itemTypes,itemCategories);
        }
        public ActionResult OnPost()
        {
            return Page();
        }

        public async void OnPostButton()
        {
           
            int item_type = FunctionHelpers.getItemTypeFromName(CategorySelection);
            
            //get items of that category
            List<Item> items = Requests.Requests.GetItemsFromType(item_type);//call rest

            //display the items of that category
            HtmlContext = GenerateHTMLContext.GenerateMenuHTMLContextForItems(items);
        }
    }
}
