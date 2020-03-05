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
    public class DetailsModel : PageModel
    {
        private readonly Crud_RazorPages_EF.Models.FuncionarioContext _context;

        public DetailsModel(Crud_RazorPages_EF.Models.FuncionarioContext context)
        {
            _context = context;
        }

        public Funcionario Funcionario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionario = await _context.Funcionario.FirstOrDefaultAsync(m => m.Id == id);

            if (Funcionario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
