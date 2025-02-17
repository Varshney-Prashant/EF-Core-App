using EfCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp.Persistence.FluentApis
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property<DateTime>("CreatedDate");
            builder.Property<Guid>("CreatedBy");
            builder.Property<DateTime>("UpdatedDate");
            builder.Property<DateTime>("UpdatedBy");
        }
    }
}
