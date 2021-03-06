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
    public partial class VendorMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.Vendor>
    {
        public VendorMap()
        {
            // table
            ToTable("Vendor", "Purchasing");

            // keys
            HasKey(t => t.VendorID);

            // Properties
            Property(t => t.VendorID)
                .HasColumnName("VendorID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.AccountNumber)
                .HasColumnName("AccountNumber")
                .HasMaxLength(15)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.CreditRating)
                .HasColumnName("CreditRating")
                .IsRequired();
            Property(t => t.PreferredVendorStatus)
                .HasColumnName("PreferredVendorStatus")
                .IsRequired();
            Property(t => t.ActiveFlag)
                .HasColumnName("ActiveFlag")
                .IsRequired();
            Property(t => t.PurchasingWebServiceURL)
                .HasColumnName("PurchasingWebServiceURL")
                .HasMaxLength(1024)
                .IsOptional();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}

