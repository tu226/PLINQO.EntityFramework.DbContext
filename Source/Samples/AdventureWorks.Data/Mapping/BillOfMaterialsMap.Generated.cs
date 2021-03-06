﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Data.Mapping
{
    public partial class BillOfMaterialsMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.BillOfMaterials>
    {
        public BillOfMaterialsMap()
        {
            // table
            ToTable("BillOfMaterials", "Production");

            // keys
            HasKey(t => t.BillOfMaterialsID);

            // Properties
            Property(t => t.BillOfMaterialsID)
                .HasColumnName("BillOfMaterialsID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.ProductAssemblyID)
                .HasColumnName("ProductAssemblyID")
                .IsOptional();
            Property(t => t.ComponentID)
                .HasColumnName("ComponentID")
                .IsRequired();
            Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();
            Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .IsOptional();
            Property(t => t.UnitMeasureCode)
                .HasColumnName("UnitMeasureCode")
                .HasMaxLength(3)
                .IsRequired();
            Property(t => t.BOMLevel)
                .HasColumnName("BOMLevel")
                .IsRequired();
            Property(t => t.PerAssemblyQty)
                .HasColumnName("PerAssemblyQty")
                .HasPrecision(8, 2)
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.ComponentProduct)
                .WithMany(t => t.ComponentBillOfMaterials)
                .HasForeignKey(d => d.ComponentID)
                .WillCascadeOnDelete(false);
            HasOptional(t => t.AssemblyProduct)
                .WithMany(t => t.AssemblyBillOfMaterials)
                .HasForeignKey(d => d.ProductAssemblyID)
                .WillCascadeOnDelete(false);
            HasRequired(t => t.UnitMeasure)
                .WithMany(t => t.BillOfMaterials)
                .HasForeignKey(d => d.UnitMeasureCode)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}

