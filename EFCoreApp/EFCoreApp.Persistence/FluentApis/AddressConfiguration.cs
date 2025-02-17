using EfCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp.Persistence.FluentApis
{
    // TODO: This can be done for all entities at once in OnModelCreating looping through all entities
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property<DateTime>("CreatedDate");
            builder.Property<Guid>("CreatedBy");
            builder.Property<DateTime>("UpdatedDate");
            builder.Property<DateTime>("UpdatedBy");
        }
    }
}
