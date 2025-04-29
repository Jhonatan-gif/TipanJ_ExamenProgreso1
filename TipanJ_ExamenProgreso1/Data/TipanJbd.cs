using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TipanJ_ExamenProgreso1.Models;

    public class TipanJbd : DbContext
    {
        public TipanJbd (DbContextOptions<TipanJbd> options)
            : base(options)
        {
        }

        public DbSet<TipanJ_ExamenProgreso1.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<TipanJ_ExamenProgreso1.Models.Reserva> Reserva { get; set; } = default!;

public DbSet<TipanJ_ExamenProgreso1.Models.Recompensa> Recompensa { get; set; } = default!;
    }
