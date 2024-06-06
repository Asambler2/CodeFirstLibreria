using CodeFirstLibreria.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstLibreria.Services
{
    public class ContextoLibro : IRepositorioLibros
    {
        private readonly LibreriaContext _context = new();
        public bool Agregar(Libro libro)
        {
            if (DameUno(libro.Id) != null)
            {

                return false;
            }
            else
            {
                _context.Add(libro);
                _context.SaveChanges();
                return true;
            }
        }

        public bool BorrarUsuario(int Id)
        {
            if (DameUno(Id) != null)
            {
                _context.Libros.Remove(DameUno(Id));
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Libro> DameTodos()
        {
            return _context.Libros.AsNoTracking().ToList();
        }

        public Libro? DameUno(int Id)
        {
            return _context.Libros.Find(Id);
        }

        public void Modificar(int Id, Libro libro)
        {
            var recupera = DameUno(Id);
            if (recupera != null)
            {
                BorrarUsuario(Id);
            }
            Agregar(libro);
        }
    }
}
