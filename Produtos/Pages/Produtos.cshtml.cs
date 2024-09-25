using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Produtos.Pages
{
public class ProdutosModel : PageModel
{
 private static List<string> produtos = new List<string>();
[BindProperty]
 public string NovoProduto { get; set; }
 public List<string> Produtos => produtos;
 public void OnGet()
 {
}
 public void OnPost()
{
  if (!string.IsNullOrEmpty(NovoProduto))
{
    produtos.Add(NovoProduto);
    NovoProduto = string.Empty; 
     }
   }
 }
}
