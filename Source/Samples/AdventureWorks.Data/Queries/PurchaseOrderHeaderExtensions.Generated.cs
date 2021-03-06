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
using System.Linq;
using System.Text;

namespace AdventureWorks.Data.Queries
{
    public static partial class PurchaseOrderHeaderExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.PurchaseOrderHeader GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.PurchaseOrderHeader> queryable, int purchaseOrderID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.PurchaseOrderHeader>;
            if (dbSet != null)
                return dbSet.Find(purchaseOrderID);
                
            return queryable.FirstOrDefault(p => p.PurchaseOrderID == purchaseOrderID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.PurchaseOrderHeader> ByEmployeeID(this IQueryable<AdventureWorks.Data.Entities.PurchaseOrderHeader> queryable, int employeeID)
        {
            return queryable.Where(p => p.EmployeeID == employeeID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.PurchaseOrderHeader> ByVendorID(this IQueryable<AdventureWorks.Data.Entities.PurchaseOrderHeader> queryable, int vendorID)
        {
            return queryable.Where(p => p.VendorID == vendorID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.PurchaseOrderHeader> ByShipMethodID(this IQueryable<AdventureWorks.Data.Entities.PurchaseOrderHeader> queryable, int shipMethodID)
        {
            return queryable.Where(p => p.ShipMethodID == shipMethodID);
        }
    }
}

