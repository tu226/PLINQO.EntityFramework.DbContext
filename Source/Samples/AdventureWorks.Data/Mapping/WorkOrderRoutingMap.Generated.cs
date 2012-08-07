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
    public partial class WorkOrderRoutingMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.WorkOrderRouting>
    {
        public WorkOrderRoutingMap()
        {
            // table
            ToTable("WorkOrderRouting", "Production");

            // keys
            HasKey(t => new { t.WorkOrderID, t.ProductID, t.OperationSequence });

            // Properties
            Property(t => t.WorkOrderID)
                .HasColumnName("WorkOrderID")
                .IsRequired();
            Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            Property(t => t.OperationSequence)
                .HasColumnName("OperationSequence")
                .IsRequired();
            Property(t => t.LocationID)
                .HasColumnName("LocationID")
                .IsRequired();
            Property(t => t.ScheduledStartDate)
                .HasColumnName("ScheduledStartDate")
                .IsRequired();
            Property(t => t.ScheduledEndDate)
                .HasColumnName("ScheduledEndDate")
                .IsRequired();
            Property(t => t.ActualStartDate)
                .HasColumnName("ActualStartDate")
                .IsOptional();
            Property(t => t.ActualEndDate)
                .HasColumnName("ActualEndDate")
                .IsOptional();
            Property(t => t.ActualResourceHrs)
                .HasColumnName("ActualResourceHrs")
                .HasPrecision(9, 4)
                .IsOptional();
            Property(t => t.PlannedCost)
                .HasColumnName("PlannedCost")
                .HasPrecision(19, 4)
                .IsRequired();
            Property(t => t.ActualCost)
                .HasColumnName("ActualCost")
                .HasPrecision(19, 4)
                .IsOptional();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.Location)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.LocationID)
                .WillCascadeOnDelete(false);
            HasRequired(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.WorkOrderID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
