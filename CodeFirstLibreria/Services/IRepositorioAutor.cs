using CodeFirstLibreria.Models;

namespace CodeFirstLibreria.Services
{
    public interface IRepositorioAutor
    {
        List<Autor> DameTodos();
        Autor? DameUno(int Id);
        bool BorrarUsuario(int Id);
        bool Agregar(Autor sutor);
        void Modificar(int Id, Autor autor);
    }
}
