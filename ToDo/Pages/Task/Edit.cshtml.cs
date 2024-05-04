using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Pages.Task
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly AppDbContext _db;
        public UserTask Task { get; set; }
       
        public EditModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Task = _db.Task.Find(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid) {
                _db.Task.Update(Task);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category updated successfully !";
                return RedirectToPage("Index");
            }
            else {
                return Page();
            }
        }
    }
}
