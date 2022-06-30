using DashBoardDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Config
{
    internal class ContentConfig :IEntityTypeConfiguration<ContentEntity>
    {
        public void Configure(EntityTypeBuilder<ContentEntity> builder)
        {


            builder.ToTable("Content");

            builder.Property(b => b.Text)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(b=>b.BoardId)
                .IsRequired();







            //builder.ToTable(nameof(ContentEntity));

            //builder.HasKey(x => x.Id).HasName("PK_Content");

            //builder.Property(x => x.Text).HasMaxLength(500);


            //builder.HasOne<BoardEntity>(g => g.TitleBoard).WithMany(w=>w.Contents).HasForeignKey(x => x.BoardId);



        }
    }
}
