using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Formulario_Cadastro_Pessoa.Models;

namespace Formulario_Cadastro_Pessoa.Data
{
    public class Formulario_Cadastro_PessoaContext : DbContext
    {
        public Formulario_Cadastro_PessoaContext (DbContextOptions<Formulario_Cadastro_PessoaContext> options)
            : base(options)
        {
        }

        public DbSet<Formulario_Cadastro_Pessoa.Models.Cliente> Cliente { get; set; } = default!;
    }
}
