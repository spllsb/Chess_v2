using System;
using Chess.Core.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chess.Infrastructure.EF
{
    public class MyDbContext
    {
        public virtual DbSet<Tournament> Tournaments { get; set; }


    }

}