using Startup.Models;

namespace Startup.DAL
{
    public class NoteRepository
    {
        private readonly NoteDbContext _dbContext;

        public NoteRepository(NoteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _dbContext.Notes.ToList();
        }
    }
}
