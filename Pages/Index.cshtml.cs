using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using System.Web.Services;
using System.Web;

namespace WhatsappMessageSender.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [Required]
        public string Username { get; set; }

        [BindProperty]
        [Required]
        public string Password { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
        public void HandleIT()
        {
            Console.WriteLine("asd");
        }
        // Remove the WebMethod attribute as it is not applicable in Blazor
        // [WebMethod]
        //[WebMethod]
        public static string ProcessIT(string name, string address)
        {
            string result = "Welcome Mr. " + name + ". Your address is '" + address + "'.";
            return result;
        }
        public void HandleValidSubmit()
        {
            // Handle the form submission
        }

        public void TriggerFunction()
        {
            // Handle the button click
        }
    }
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
