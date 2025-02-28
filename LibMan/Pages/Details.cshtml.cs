﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibMan.Models.DB;

namespace LibMan.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly LibMan.Models.DB.LibmanContext _context;

        public DetailsModel(LibMan.Models.DB.LibmanContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.Userid == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
