using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Pages.Task
{
    [BindProperties]
    public class AddModel : PageModel
    {
        private readonly AppDbContext _db;
        public UserTask Task { get; set; }
       
        public AddModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid) {
                await _db.Task.AddAsync(Task);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else {
                return Page();
            }
        }
    }
}
