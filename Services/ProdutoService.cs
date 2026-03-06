using PDV.Repositories;
using PDV.Repositories.Interface;
using PDV.Services.Interface;

namespace PDV.Services
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) 
        {
            _produtoRepository = produtoRepository;
        }

    }
}
