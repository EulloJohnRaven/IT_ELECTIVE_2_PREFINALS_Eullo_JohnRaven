using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Portfolio.Models;
using Portfolio.Data;
using System.Linq;

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        // GET: /Project/Details/1
        public IActionResult Details(int id)
        {
            var project = MockDataStore.Projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            var viewModel = new ProjectDetailsViewModel
            {
                Project = project,
                Comments = MockDataStore.Comments.Where(c => c.ProjectId == id).ToList(),
                NewComment = new Comment { ProjectId = id }
            };

            ViewBag.IsLoggedIn = HttpContext.Session.GetString("IsLoggedIn") == "true";

            return View(viewModel);
        }

        // POST: /Project/AddComment
        [HttpPost]
        public IActionResult AddComment(ProjectDetailsViewModel model)
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            if (!string.IsNullOrWhiteSpace(model.NewComment.CommentText))
            {
                var comment = model.NewComment;
                comment.Id = MockDataStore.Comments.Count + 1;
                comment.AuthorName = HttpContext.Session.GetString("Username") ?? "Admin";

                MockDataStore.Comments.Add(comment);
            }

            return RedirectToAction("Details", new { id = model.NewComment.ProjectId });
        }
    }
}