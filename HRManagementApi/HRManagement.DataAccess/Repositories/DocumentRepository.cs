using HRManagement.DataAccess.DbContexts;

namespace HRManagement.DataAccess.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly HRManagementDBContext _context;

        public DocumentRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
