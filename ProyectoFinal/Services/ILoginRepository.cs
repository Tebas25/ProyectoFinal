using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Services
{
    public  interface ILoginRepository
    {
        Task<Usuario> Login(string username, string password); 
    }
}
