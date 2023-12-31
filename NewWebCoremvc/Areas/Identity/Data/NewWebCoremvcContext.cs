﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewWebCoremvc.Areas.Identity.Data;

namespace NewWebCoremvc.Data;

public class NewWebCoremvcContext : IdentityDbContext<NewWebCoremvcUser>
{
    public NewWebCoremvcContext(DbContextOptions<NewWebCoremvcContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApllicationUserEntityConfiguration)
    }
}


public class ApllicationUserEntityConfiguration : IEntityTypeConfiguration<NewWebCoremvcUser>
{
    public void Configure(EntityTypeBuilder<NewWebCoremvcUser> builder)
    {
       builder.Property(x = x => x.Id).HasColumnName("Id");
        builder.Property(x = x => x.Id).HasColumnName("Id");
        builder.Property(x = x => x.Id).HasColumnName("Id");
        builder.Property(x = x => x.Id).HasColumnName("Id");
    }
}
