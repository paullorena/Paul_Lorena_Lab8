﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Paul_Lorena_Lab8.Models;

namespace Paul_Lorena_Lab8.Data
{
    public class Paul_Lorena_Lab8Context : DbContext
    {
        public Paul_Lorena_Lab8Context (DbContextOptions<Paul_Lorena_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Paul_Lorena_Lab8.Models.Book> Book { get; set; }

        public DbSet<Paul_Lorena_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Paul_Lorena_Lab8.Models.Category> Category { get; set; }
    }
}
