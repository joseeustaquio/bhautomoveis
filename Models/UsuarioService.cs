using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BH_Automoveis.Models
{
    public class UsuarioService
    {
        public int CadastrarUsuario(Usuario novoUsuario)
        {
            using (var context = new BhautomoveisContext())
            {
                context.Add(novoUsuario);
                context.SaveChanges();
                return novoUsuario.Id;
            }
        }
    }
}