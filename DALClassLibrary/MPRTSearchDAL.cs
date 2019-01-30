using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using MPRTSearch.BusinessEntities;

namespace MPRTSearch.DAL
{
    public class MPRTSearchDAL : DbContext
    {
        public DbSet<SearchDataSet> SearchDataSets { get; set; }
        public DbSet<TypeTable> TypeTables { get; set; }
        public DbSet<ColumnTable> ColumnTables { get; set; }


        public MPRTSearchDAL() : base("DBString")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TypeTableMap());
            modelBuilder.Configurations.Add(new ColumnTableMap());
            modelBuilder.Configurations.Add(new SearchDataSetMap());

            base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// Model  Object Mapping Class : TypeTable
        /// </summary>
        public class TypeTableMap : EntityTypeConfiguration<TypeTable>
        {
            public TypeTableMap()
            {
                this.ToTable("TypeTable");
                this.HasKey(p => p.ID);
                this.Property(p => p.TypeName).IsRequired().HasMaxLength(50).HasColumnName("TypeName").IsUnicode(true);
                this.Property(p => p.Sorting).IsRequired().HasColumnName("Sorting");
                this.Property(p => p.Enabled).IsRequired().HasColumnName("Enabled");
                // config TypeTable.ID : ColumnTable.TypeID (1:0..n)
                this.HasMany(p => p._columnTable).WithOptional(p => p._typeTable).HasForeignKey(p => p.TypeID);
                // config TypeTable.ID : SearchDataSet.TypeID (1:0..n)
                this.HasMany(p => p._searchDataSet).WithOptional(p => p._typeTable).HasForeignKey(p => p.TypeID);
            }
        }

        /// <summary>
        /// Model  Object Mapping Class : ColumnTable
        /// </summary>
        public class ColumnTableMap : EntityTypeConfiguration<ColumnTable>
        {
            public ColumnTableMap()
            {
                this.ToTable("ColumnTable");
                this.HasKey(p => p.ID);
                this.Property(p => p.TypeID).IsRequired().HasColumnName("TypeID");
                this.Property(p => p.Sorting).IsRequired().HasColumnName("Sorting");
                this.Property(p => p.Enabled).IsRequired().HasColumnName("Enabled");
                this.Property(p => p.ColumnName).IsRequired().HasMaxLength(50).HasColumnName("ColumnName").IsUnicode(true);
                
            }
        }
        /// <summary>
        /// Model  Object Mapping Class : SearchDataSet
        /// </summary>
        public class SearchDataSetMap : EntityTypeConfiguration<SearchDataSet>
        {
            public SearchDataSetMap()
            {
                this.ToTable("SearchDataSet");
                this.HasKey(p => p.ID);
                this.Property(p => p.TypeID).IsRequired().HasColumnName("TypeID");
                this.Property(p => p.Enabled).IsRequired().HasColumnName("Enabled");
                this.Property(p => p.Column01).IsRequired().HasMaxLength(255).HasColumnName("Column01").IsUnicode(true);
                this.Property(p => p.Column02).IsRequired().HasMaxLength(255).HasColumnName("Column02").IsUnicode(true);
                this.Property(p => p.Column03).IsRequired().HasMaxLength(255).HasColumnName("Column03").IsUnicode(true);
                this.Property(p => p.Column04).IsRequired().HasMaxLength(255).HasColumnName("Column04").IsUnicode(true);
                this.Property(p => p.Column05).IsRequired().HasMaxLength(255).HasColumnName("Column05").IsUnicode(true);
                this.Property(p => p.Column06).IsRequired().HasMaxLength(255).HasColumnName("Column06").IsUnicode(true);
                this.Property(p => p.Column07).IsRequired().HasMaxLength(255).HasColumnName("Column07").IsUnicode(true);
                this.Property(p => p.Column08).IsRequired().HasMaxLength(255).HasColumnName("Column08").IsUnicode(true);
                this.Property(p => p.Column09).IsRequired().HasMaxLength(255).HasColumnName("Column09").IsUnicode(true);
                this.Property(p => p.Column10).IsRequired().HasMaxLength(255).HasColumnName("Column10").IsUnicode(true);
                this.Property(p => p.Column11).IsRequired().HasMaxLength(255).HasColumnName("Column11").IsUnicode(true);
                this.Property(p => p.Column12).IsRequired().HasMaxLength(255).HasColumnName("Column12").IsUnicode(true);
                this.Property(p => p.Column13).IsRequired().HasMaxLength(255).HasColumnName("Column13").IsUnicode(true);
                this.Property(p => p.Column14).IsRequired().HasMaxLength(255).HasColumnName("Column14").IsUnicode(true);
                this.Property(p => p.Column15).IsRequired().HasMaxLength(255).HasColumnName("Column15").IsUnicode(true);
                this.Property(p => p.Column16).IsRequired().HasMaxLength(255).HasColumnName("Column16").IsUnicode(true);
                this.Property(p => p.Column17).IsRequired().HasMaxLength(255).HasColumnName("Column17").IsUnicode(true);
                this.Property(p => p.Column18).IsRequired().HasMaxLength(255).HasColumnName("Column18").IsUnicode(true);
                this.Property(p => p.Column19).IsRequired().HasMaxLength(255).HasColumnName("Column19").IsUnicode(true);
                this.Property(p => p.Column20).IsRequired().HasMaxLength(255).HasColumnName("Column20").IsUnicode(true);
                this.Property(p => p.Column21).IsRequired().HasMaxLength(255).HasColumnName("Column21").IsUnicode(true);
                this.Property(p => p.Column22).IsRequired().HasMaxLength(255).HasColumnName("Column22").IsUnicode(true);
                this.Property(p => p.Column23).IsRequired().HasMaxLength(255).HasColumnName("Column23").IsUnicode(true);
                this.Property(p => p.Column24).IsRequired().HasMaxLength(255).HasColumnName("Column24").IsUnicode(true);
                this.Property(p => p.Column25).IsRequired().HasMaxLength(255).HasColumnName("Column25").IsUnicode(true);
                this.Property(p => p.Column26).IsRequired().HasMaxLength(255).HasColumnName("Column26").IsUnicode(true);
                this.Property(p => p.Column27).IsRequired().HasMaxLength(255).HasColumnName("Column27").IsUnicode(true);
                this.Property(p => p.Column28).IsRequired().HasMaxLength(255).HasColumnName("Column28").IsUnicode(true);
                this.Property(p => p.Column29).IsRequired().HasMaxLength(255).HasColumnName("Column29").IsUnicode(true);
                this.Property(p => p.Column30).IsRequired().HasMaxLength(255).HasColumnName("Column30").IsUnicode(true);
                this.Property(p => p.Column31).IsRequired().HasMaxLength(255).HasColumnName("Column31").IsUnicode(true);
                this.Property(p => p.Column32).IsRequired().HasMaxLength(255).HasColumnName("Column32").IsUnicode(true);
                this.Property(p => p.Column33).IsRequired().HasMaxLength(255).HasColumnName("Column33").IsUnicode(true);
                this.Property(p => p.Column34).IsRequired().HasMaxLength(255).HasColumnName("Column34").IsUnicode(true);
                this.Property(p => p.Column35).IsRequired().HasMaxLength(255).HasColumnName("Column35").IsUnicode(true);
                this.Property(p => p.Column36).IsRequired().HasMaxLength(255).HasColumnName("Column36").IsUnicode(true);
                this.Property(p => p.Column37).IsRequired().HasMaxLength(255).HasColumnName("Column37").IsUnicode(true);
                this.Property(p => p.Column38).IsRequired().HasMaxLength(255).HasColumnName("Column38").IsUnicode(true);
                this.Property(p => p.Column39).IsRequired().HasMaxLength(255).HasColumnName("Column39").IsUnicode(true);
            }
        }

        
    }

    
}
