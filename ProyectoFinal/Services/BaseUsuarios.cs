using ProyectoFinal.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Services
{

    public class BaseUsuarios
    {
        readonly SQLiteAsyncConnection baseUsuarios;

        public BaseUsuarios(string path)
        {
            baseUsuarios = new SQLiteAsyncConnection(path);
            baseUsuarios.CreateTableAsync<UsuarioDB>().Wait();
        }

        public Task<List<UsuarioDB>> GetAll()
        {
            return baseUsuarios.Table<UsuarioDB>().ToListAsync();
        }

        public Task<int> Guardar(UsuarioDB usuario)
        {
            return baseUsuarios.InsertAsync(usuario);
        }

    }
}
