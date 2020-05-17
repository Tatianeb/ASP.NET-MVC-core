using System;
using System.Threading.Tasks;
using AppMvcBeeCode.Models;

namespace BeeCode.Business.Interfaces
{
    public interface IProdutoService:IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}