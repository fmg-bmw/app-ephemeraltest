using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sampleapp.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class SampleModel : PageModel
{
    public IWebHostEnvironment _environment { get; }

    private readonly ILogger<SampleModel> _logger;

    public SampleModel(ILogger<SampleModel> logger, IWebHostEnvironment environment)
    {
        _logger = logger;
        _environment = environment;
    }

    public void OnGet()
    {
    }
}

