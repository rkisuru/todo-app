using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Pages.Task
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _db;
        public UserTask Task { get; set; }
       
        public DeleteModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet(int Id)
        {
            Task = _db.Task.Find(Id);
        }
        public async Task<IActionResult> OnPost()
        {
            var task = _db.Task.Find(Task.Id);

            if (task != null)
            {
                _db.Task.Remove(task);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else {
                return Page();
            }
        }
    }
}
