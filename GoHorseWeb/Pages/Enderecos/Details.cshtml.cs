﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GoHorseClassLibrary;
using GoHorseDAL;

namespace GoHorseWeb.Pages.Enderecos
{
    public class DetailsModel : PageModel
    {
        private readonly GoHorseDAL.GoHorseContext _context;

        public DetailsModel(GoHorseDAL.GoHorseContext context)
        {
            _context = context;
        }

        public Endereco Endereco { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Endereco = await _context.Enderecos.FirstOrDefaultAsync(m => m.EnderecoId == id);

            if (Endereco == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
