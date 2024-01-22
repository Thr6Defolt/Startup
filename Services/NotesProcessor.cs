using Startup.DAL;
using Startup.Models;

namespace Startup.Services
{
    public class NotesProcessor
    {
        private readonly NoteRepository _noteRepository;

        public NotesProcessor(NoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _noteRepository.GetAllNotes();
        }
    }
}
