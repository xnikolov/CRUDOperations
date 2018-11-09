﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDOperations.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;
        [BindProperty]
        public Customer Customer { get; set; }

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }
         
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Customers.Add(Customer);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index");

            
           
        }
    }
}