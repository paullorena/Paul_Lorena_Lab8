﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Paul_Lorena_Lab8.Data;
using Paul_Lorena_Lab8.Models;

namespace Paul_Lorena_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Paul_Lorena_Lab8.Data.Paul_Lorena_Lab8Context _context;

        public IndexModel(Paul_Lorena_Lab8.Data.Paul_Lorena_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
