﻿using Microsoft.EntityFrameworkCore;
using Sistema.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos.Mapping.Ventas
{
    public class VentaMap : IEntityTypeConfiguration<Venta>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("venta")
                  .HasKey(v => v.idventa);
            builder.HasOne(v => v.persona)
                .WithMany(p => p.ventas)
                .HasForeignKey(v => v.idcliente);
        }
    }
}
