using CodeFirstLibreria.Models;

namespace CodeFirstLibreria.Services
{
    public interface IRepositorioLibros
    {
        List<Libro> DameTodos();
        Libro? DameUno(int Id);
        bool BorrarUsuario(int Id);
        bool Agregar(Libro libro);
        void Modificar(int Id, Libro libro);
    }
}
