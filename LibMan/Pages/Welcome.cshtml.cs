using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Security.Claims;
namespace LibMan.Pages
{

 public class WelcomeModel : PageModel
 {
 public string Username { get; set; }
 public string UserId;

 public void OnGet()
 {
 // UserId = User.FindFirst(ClaimTypes.Name).Value;
 Username = HttpContext.Session.GetString("username");
 }
 public IActionResult OnGetLogout()
 {
 HttpContext.Session.Remove("username");

 return RedirectToPage("Index");
 }
 }
}