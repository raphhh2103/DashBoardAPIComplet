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
    internal class ProjectConfig : IEntityTypeConfiguration<ProjectEntity>
    {
        public void Configure(EntityTypeBuilder<ProjectEntity> builder)
        {

            builder.ToTable("Project");

            builder.Property(p => p.NameProject);



            //builder.ToTable(nameof(TeamEntity));
            //builder.HasKey(t => t.Id).HasName("PK_Team ");  
            //builder.Property(t => t.Name);

            //builder.HasMany<UserEntity>(p => p.TeamUsers).WithMany(g => g.Teams);
            
        }
    }
}
