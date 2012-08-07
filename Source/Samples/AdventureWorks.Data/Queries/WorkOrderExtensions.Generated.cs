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
    public static partial class WorkOrderExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.WorkOrder GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.WorkOrder> queryable, int workOrderID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.WorkOrder>;
            if (dbSet != null)
                return dbSet.Find(workOrderID);
                
            return queryable.FirstOrDefault(w => w.WorkOrderID == workOrderID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.WorkOrder> ByProductID(this IQueryable<AdventureWorks.Data.Entities.WorkOrder> queryable, int productID)
        {
            return queryable.Where(w => w.ProductID == productID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.WorkOrder> ByScrapReasonID(this IQueryable<AdventureWorks.Data.Entities.WorkOrder> queryable, short? scrapReasonID)
        {
            return queryable.Where(w => (w.ScrapReasonID == scrapReasonID || (scrapReasonID == null && w.ScrapReasonID == null)));
        }
    }
}
