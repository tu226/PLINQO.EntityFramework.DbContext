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
    public static partial class ProductListPriceHistoryExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.ProductListPriceHistory GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.ProductListPriceHistory> queryable, int productID, System.DateTime startDate)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ProductListPriceHistory>;
            if (dbSet != null)
                return dbSet.Find(productID, startDate);
                
            return queryable.FirstOrDefault(p => p.ProductID == productID
                && p.StartDate == startDate);
        }

        public static IQueryable<AdventureWorks.Data.Entities.ProductListPriceHistory> ByProductID(this IQueryable<AdventureWorks.Data.Entities.ProductListPriceHistory> queryable, int productID)
        {
            return queryable.Where(p => p.ProductID == productID);
        }
    }
}

