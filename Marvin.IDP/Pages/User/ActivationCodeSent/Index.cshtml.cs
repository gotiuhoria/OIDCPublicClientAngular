using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Marvin.IDP.Pages.User.ActivationCodeSent;

[AllowAnonymous]
[SecurityHeaders]
public class Index : PageModel
{
    public void OnGet()
    {
        
    }
}