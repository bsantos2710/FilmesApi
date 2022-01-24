using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;

namespace FilmesApi.Data
{
    public class FilmesContext : DbContext
    {
        public FilmesContext(DbContextOptions<FilmesContext> opt) : base(opt)
        {

        }

        public DbSet<Filme> Filmes { get; set; }

       
    }
}
