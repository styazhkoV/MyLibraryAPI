﻿using System;
using Microsoft.EntityFrameworkCore;
using Books.Data.Models;
namespace Books.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
