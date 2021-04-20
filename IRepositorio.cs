Using Sistem.Colletections.Generic;

namespace PROJECT_SERIES_CARLOS_..vscode.INTERFACES
{
    public interface IREPOSITORIO
    {List<T> lista();
    T RetornaPorId(int id);
    void Insere(T entidade);
    void Exclui(int id);
    void Atualiza(int id,T entidade);
    int ProximoId();
    }
}