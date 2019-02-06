using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using MPRTSearch.BusinessEntities;
using System.ComponentModel.DataAnnotations.Schema;

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
                this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
                this.Property(p => p.TypeName).IsRequired().HasMaxLength(50).HasColumnName("TypeName").IsUnicode(true);
                this.Property(p => p.Sorting).IsRequired().HasColumnName("Sorting");
                
                // config TypeTable.ID : ColumnTable.TypeID (1:0..n)
                this.HasMany(p => p._columnTable).WithRequired(p => p._typeTable).HasForeignKey(p => p.TypeID);
                // config TypeTable.ID : SearchDataSet.TypeID (1:0..n)
                this.HasMany(p => p._searchDataSet).WithRequired(p => p._typeTable).HasForeignKey(p => p.TypeID);
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
                this.Property(p => p.Column01).IsOptional().HasMaxLength(255).HasColumnName("Column01").IsUnicode(true);
                this.Property(p => p.Column02).IsOptional().HasMaxLength(255).HasColumnName("Column02").IsUnicode(true);
                this.Property(p => p.Column03).IsOptional().HasMaxLength(255).HasColumnName("Column03").IsUnicode(true);
                this.Property(p => p.Column04).IsOptional().HasMaxLength(255).HasColumnName("Column04").IsUnicode(true);
                this.Property(p => p.Column05).IsOptional().HasMaxLength(255).HasColumnName("Column05").IsUnicode(true);
                this.Property(p => p.Column06).IsOptional().HasMaxLength(255).HasColumnName("Column06").IsUnicode(true);
                this.Property(p => p.Column07).IsOptional().HasMaxLength(255).HasColumnName("Column07").IsUnicode(true);
                this.Property(p => p.Column08).IsOptional().HasMaxLength(255).HasColumnName("Column08").IsUnicode(true);
                this.Property(p => p.Column09).IsOptional().HasMaxLength(255).HasColumnName("Column09").IsUnicode(true);
                this.Property(p => p.Column10).IsOptional().HasMaxLength(255).HasColumnName("Column10").IsUnicode(true);
                this.Property(p => p.Column11).IsOptional().HasMaxLength(255).HasColumnName("Column11").IsUnicode(true);
                this.Property(p => p.Column12).IsOptional().HasMaxLength(255).HasColumnName("Column12").IsUnicode(true);
                this.Property(p => p.Column13).IsOptional().HasMaxLength(255).HasColumnName("Column13").IsUnicode(true);
                this.Property(p => p.Column14).IsOptional().HasMaxLength(255).HasColumnName("Column14").IsUnicode(true);
                this.Property(p => p.Column15).IsOptional().HasMaxLength(255).HasColumnName("Column15").IsUnicode(true);
                this.Property(p => p.Column16).IsOptional().HasMaxLength(255).HasColumnName("Column16").IsUnicode(true);
                this.Property(p => p.Column17).IsOptional().HasMaxLength(255).HasColumnName("Column17").IsUnicode(true);
                this.Property(p => p.Column18).IsOptional().HasMaxLength(255).HasColumnName("Column18").IsUnicode(true);
                this.Property(p => p.Column19).IsOptional().HasMaxLength(255).HasColumnName("Column19").IsUnicode(true);
                this.Property(p => p.Column20).IsOptional().HasMaxLength(255).HasColumnName("Column20").IsUnicode(true);
                this.Property(p => p.Column21).IsOptional().HasMaxLength(255).HasColumnName("Column21").IsUnicode(true);
                this.Property(p => p.Column22).IsOptional().HasMaxLength(255).HasColumnName("Column22").IsUnicode(true);
                this.Property(p => p.Column23).IsOptional().HasMaxLength(255).HasColumnName("Column23").IsUnicode(true);
                this.Property(p => p.Column24).IsOptional().HasMaxLength(255).HasColumnName("Column24").IsUnicode(true);
                this.Property(p => p.Column25).IsOptional().HasMaxLength(255).HasColumnName("Column25").IsUnicode(true);
                this.Property(p => p.Column26).IsOptional().HasMaxLength(255).HasColumnName("Column26").IsUnicode(true);
                this.Property(p => p.Column27).IsOptional().HasMaxLength(255).HasColumnName("Column27").IsUnicode(true);
                this.Property(p => p.Column28).IsOptional().HasMaxLength(255).HasColumnName("Column28").IsUnicode(true);
                this.Property(p => p.Column29).IsOptional().HasMaxLength(255).HasColumnName("Column29").IsUnicode(true);
                this.Property(p => p.Column30).IsOptional().HasMaxLength(255).HasColumnName("Column30").IsUnicode(true);
                this.Property(p => p.Column31).IsOptional().HasMaxLength(255).HasColumnName("Column31").IsUnicode(true);
                this.Property(p => p.Column32).IsOptional().HasMaxLength(255).HasColumnName("Column32").IsUnicode(true);
                this.Property(p => p.Column33).IsOptional().HasMaxLength(255).HasColumnName("Column33").IsUnicode(true);
                this.Property(p => p.Column34).IsOptional().HasMaxLength(255).HasColumnName("Column34").IsUnicode(true);
                this.Property(p => p.Column35).IsOptional().HasMaxLength(255).HasColumnName("Column35").IsUnicode(true);
                this.Property(p => p.Column36).IsOptional().HasMaxLength(255).HasColumnName("Column36").IsUnicode(true);
                this.Property(p => p.Column37).IsOptional().HasMaxLength(255).HasColumnName("Column37").IsUnicode(true);
                this.Property(p => p.Column38).IsOptional().HasMaxLength(255).HasColumnName("Column38").IsUnicode(true);
                this.Property(p => p.Column39).IsOptional().HasMaxLength(255).HasColumnName("Column39").IsUnicode(true);
            }
        }

        
    }

    
}
