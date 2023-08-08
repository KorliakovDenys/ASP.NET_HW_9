using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_HW_9.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        private readonly IHttpContextAccessor _httpContextAccessor;

        public string? Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor httpContextAccessor) {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet() {
            Name = _httpContextAccessor.HttpContext?.Request.Cookies["name"];
        }
    }
}