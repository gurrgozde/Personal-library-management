using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Http;

namespace LibMan.Pages
{
    public class LoginModel : PageModel
    {
        private readonly LibMan.Models.DB.LibmanContext _context;

        public LoginModel(LibMan.Models.DB.LibmanContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string Msg { get; set; }
        public IActionResult OnPost()
        {
            if (UserExists(Email, Password))
            {
                //HttpContext.Session.SetString("username", Username);
                var cust = _context.User.Single(a => a.Email == Email);
                HttpContext.Session.SetString("email", cust.Email);
                // return RedirectToPage("Welcome");
                return RedirectToPage("Welcome");
            }
         

            else
            {
                Msg = "Invalid";
                return Page();
            }
        }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
        private bool UserExists(string email, string password)
        {
            bool usern = false, pass = false;
            usern = _context.User.Any(e => e.Email == email);
            pass = _context.User.Any(e => e.Password == password);
            if (usern == true && pass == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

