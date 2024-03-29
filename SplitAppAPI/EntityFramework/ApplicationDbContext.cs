﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SplitAppAPI.Models;

namespace UserRegistration.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt) { }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
    }
}
