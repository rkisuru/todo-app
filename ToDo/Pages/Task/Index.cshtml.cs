using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Pages.Task
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;
        public IEnumerable<UserTask> UserTasks { get; set; }
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            UserTasks = _db.Task;
        }
    }
}
