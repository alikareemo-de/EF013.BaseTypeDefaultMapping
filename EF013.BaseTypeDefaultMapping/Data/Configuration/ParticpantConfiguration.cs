using EF013.BaseTypeDefaultMapping.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF013.BaseTypeDefaultMapping.Data.Configuration
{
    public class ParticpantConfiguration : IEntityTypeConfiguration<Particpant>
    {
        public void Configure(EntityTypeBuilder<Particpant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.FName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.LName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50).IsRequired();

            builder.UseTpcMappingStrategy();

            builder.ToTable("Particpants");


        }


    }
}
