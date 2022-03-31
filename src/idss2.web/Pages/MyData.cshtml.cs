using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace idss2.web.Pages;

public class MyDataModel : PageModel
{
    private readonly ILogger<MyDataModel> _logger;

    public MyDataModel(ILogger<MyDataModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
