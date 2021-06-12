using System.Collections.Generic;

namespace CadastroNET
{
    public interface IRepositorio<T> where T: class
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}