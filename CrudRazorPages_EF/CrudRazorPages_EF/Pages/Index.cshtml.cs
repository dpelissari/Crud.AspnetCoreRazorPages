using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudRazorPages_EF.Models;
using Crud_RazorPages_EF.Models;

namespace CrudRazorPages_EF
{
    public class IndexModel : PageModel
    {
        private readonly Crud_RazorPages_EF.Models.FuncionarioContext _context;

        public IndexModel(Crud_RazorPages_EF.Models.FuncionarioContext context)
        {
            _context = context;
        }

        public IList<Funcionario> Funcionario { get;set; }

        public async Task OnGetAsync()
        {
            Funcionario = await _context.Funcionario.ToListAsync();
        }
    }
}
