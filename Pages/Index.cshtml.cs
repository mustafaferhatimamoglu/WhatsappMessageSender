using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WhatsappMessageSender.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnGetWriteLog(string msg)
        {
            if (msg == "error")
            {
                return BadRequest("WRONG");
            }
            return new JsonResult(msg);
        }
    }
}
