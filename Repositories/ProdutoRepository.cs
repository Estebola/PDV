using PDV.Infra.Context;
using PDV.Repositories.Interface;

namespace PDV.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

     }
}
