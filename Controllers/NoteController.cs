using Microsoft.AspNetCore.Mvc;
using Startup.Services;

namespace Startup.Controllers
{
    public class NoteController : Controller
    {
        private readonly NotesProcessor _notesProcessor;

        public NoteController(NotesProcessor notesProcessor)
        {
            _notesProcessor = notesProcessor;
        }

        public IActionResult Index()
        {
            var notes = _notesProcessor.GetAllNotes();
            return View(notes);
        }
    }
}
