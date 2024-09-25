using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Produtos.Pages
{
public class PrivacyModel : PageModel
{
private readonly ILogger<PrivacyModel> _logger;
 public PrivacyModel(ILogger<PrivacyModel> logger)
{
 _logger = logger;
 }
public void OnGet()
   {
  }
 }

}
