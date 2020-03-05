using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudRazorPages_EF.Models;

namespace Crud_RazorPages_EF.Models
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext (DbContextOptions<FuncionarioContext> options)
            : base(options)
        {
        }

        public DbSet<CrudRazorPages_EF.Models.Funcionario> Funcionario { get; set; }
    }
}
