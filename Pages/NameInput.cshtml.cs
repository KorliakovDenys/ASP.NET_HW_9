using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_HW_9.Pages {
    public class NameInput : PageModel {
        private readonly ILogger<NameInput> _logger;

        private readonly IHttpContextAccessor _httpContextAccessor;

        public NameInput(ILogger<NameInput> logger, IHttpContextAccessor httpContextAccessor) {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet() { }

        public IActionResult OnPostName(string name) {
            _httpContextAccessor.HttpContext?.Response.Cookies.Append("name", name);

            return RedirectToPage("/Index");
        }
    }
}