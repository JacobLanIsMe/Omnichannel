using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Model;

public partial class OmnichannelContext : DbContext
{
    public OmnichannelContext(DbContextOptions<OmnichannelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Message> Message { get; set; }

    public virtual DbSet<UserConnection> UserConnection { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Message>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SentAt).HasColumnType("datetime");
            entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UserConnection>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ConnectedAt).HasColumnType("datetime");
            entity.Property(e => e.ConnectionId).HasMaxLength(50);
            entity.Property(e => e.DisconnectedAt).HasColumnType("datetime");
            entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
