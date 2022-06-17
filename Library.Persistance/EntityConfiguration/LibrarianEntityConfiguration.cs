using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Library.Persistance.EntityConfiguration
{
    public class LibrarianEntityConfiguration : IEntityTypeConfiguration<LibrarianEntity>
    {
        public void Configure(EntityTypeBuilder<LibrarianEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}
