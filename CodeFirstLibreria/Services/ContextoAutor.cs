using CodeFirstLibreria.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstLibreria.Services
{
    public class ContextoAutor : IRepositorioAutor
    {
        private readonly LibreriaContext _context = new();
        public bool Agregar(Autor autor)
        {
            if (DameUno(autor.Id) != null)
            {

                return false;
            }
            else
            {
                _context.Add(autor);
                _context.SaveChanges();
                return true;
            }
        }

        public bool BorrarUsuario(int Id)
        {
            if (DameUno(Id) != null)
            {
                _context.Autores.Remove(DameUno(Id));
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Autor> DameTodos()
        {
            return _context.Autores.AsNoTracking().ToList();
        }

        public Autor? DameUno(int Id)
        {
            return _context.Autores.Find(Id);
        }

        public void Modificar(int Id, Autor autor)
        {
            var recupera = DameUno(Id);
            if (recupera != null)
            {
                BorrarUsuario(Id);
            }
            Agregar(autor);
        }
    }
}
