using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Library.Persistance.EntityConfiguration
{
    public class ReaderEntityConfiguration : IEntityTypeConfiguration<ReaderEntity>
    {
        public void Configure(EntityTypeBuilder<ReaderEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
