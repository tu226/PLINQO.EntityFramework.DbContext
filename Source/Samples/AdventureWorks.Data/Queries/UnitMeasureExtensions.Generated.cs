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
    public static partial class UnitMeasureExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.UnitMeasure GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.UnitMeasure> queryable, string unitMeasureCode)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.UnitMeasure>;
            if (dbSet != null)
                return dbSet.Find(unitMeasureCode);
                
            return queryable.FirstOrDefault(u => u.UnitMeasureCode == unitMeasureCode);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.UnitMeasure GetByName(this IQueryable<AdventureWorks.Data.Entities.UnitMeasure> queryable, string name)
        {
            return queryable.FirstOrDefault(u => u.Name == name);
        }
    }
}
