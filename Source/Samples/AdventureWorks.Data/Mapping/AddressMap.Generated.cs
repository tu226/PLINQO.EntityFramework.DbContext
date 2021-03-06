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
    public partial class AddressMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.Address>
    {
        public AddressMap()
        {
            // table
            ToTable("Address", "Person");

            // keys
            HasKey(t => t.AddressID);

            // Properties
            Property(t => t.AddressID)
                .HasColumnName("AddressID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.AddressLine1)
                .HasColumnName("AddressLine1")
                .HasMaxLength(60)
                .IsRequired();
            Property(t => t.AddressLine2)
                .HasColumnName("AddressLine2")
                .HasMaxLength(60)
                .IsOptional();
            Property(t => t.City)
                .HasColumnName("City")
                .HasMaxLength(30)
                .IsRequired();
            Property(t => t.StateProvinceID)
                .HasColumnName("StateProvinceID")
                .IsRequired();
            Property(t => t.PostalCode)
                .HasColumnName("PostalCode")
                .HasMaxLength(15)
                .IsRequired();
            Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasMany(t => t.Employees)
                .WithMany(t => t.address)
                .Map(m =>
                {
                    m.ToTable("EmployeeAddress", "HumanResources");
                    m.MapLeftKey("AddressID");
                    m.MapRightKey("EmployeeID");
                });
            HasRequired(t => t.StateProvince)
                .WithMany(t => t.Address)
                .HasForeignKey(d => d.StateProvinceID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}

