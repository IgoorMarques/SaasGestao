using dominio.Interfaces.Generics;
using Infra.config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Infra.repository.generics
{
    public class RepositorioGeneric<T> : InterfaceGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilder;

        public RepositorioGeneric()
        {
            _optionsBuilder = new DbContextOptionsBuilder<ContextBase>().Options;
        }

        public async Task Add(T objeto)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                await data.Set<T>().AddAsync(objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T objeto)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                data.Set<T>().Remove(objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<T> GetEntityByID(int id)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                var result = await data.Set<T>().FindAsync(id);
                if (result == null)
                {
                    throw new Exception("Não encontrado");
                }
                return result;
            }
        }

        public async Task<List<T>> List()
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                return await data.Set<T>().ToListAsync();
            }
        }

        public async Task Update(T objeto)
        {
            using (var data = new ContextBase(_optionsBuilder))
            {
                data.Set<T>().Update(objeto);
                await data.SaveChangesAsync();
            }
        }

        #region Disposed
        private bool disposed = false;
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                handle.Dispose();
                // Libere outros recursos gerenciados aqui.
            }

            disposed = true;
        }
        #endregion
    }
}
