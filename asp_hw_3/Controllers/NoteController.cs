using asp_hw_3.Models;
using asp_hw_3.Services;
using Microsoft.AspNetCore.Mvc;

namespace asp_hw_3.Controllers
{
    public class NoteController : Controller
    {
        private readonly NoteService _noteService;

        public NoteController(NoteService noteService)
        {
            _noteService = noteService;
        }

        public IActionResult Index()
        {
            List<NoteModel> notes = new List<NoteModel>
            {
                new NoteModel("Title1", "Text1", DateTime.Now, new[] { "tag1", "tag2" }),
                new NoteModel("Title2", "Text2", DateTime.Now, new[] { "tag3", "tag4" })
            };

            _noteService.SaveNotesToJson(notes);

            return View();
        }

    }
}
