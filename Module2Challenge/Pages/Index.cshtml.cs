using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module2Challenge.Pages;

public class IndexModel : PageModel {
// Create properties to store the miles driven and gallons used values. 

    [BindProperty]
    public double MilesDriven { get; set; }
    
    [BindProperty]
    public double GallonsUsed { get; set; }

    public double MPG { get; set; }

    public bool ShowResult { get; set; }

    public void OnGet() {
        ShowResult = false;
    }

    public void OnPost(){
        MPG = MilesDriven / GallonsUsed;
        ShowResult = true;
    }
}
