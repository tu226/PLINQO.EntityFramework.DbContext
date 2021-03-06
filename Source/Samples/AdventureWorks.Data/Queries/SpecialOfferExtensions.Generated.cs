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
    public static partial class SpecialOfferExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.SpecialOffer GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.SpecialOffer> queryable, int specialOfferID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.SpecialOffer>;
            if (dbSet != null)
                return dbSet.Find(specialOfferID);
                
            return queryable.FirstOrDefault(s => s.SpecialOfferID == specialOfferID);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.SpecialOffer GetByRowguid(this IQueryable<AdventureWorks.Data.Entities.SpecialOffer> queryable, System.Guid rowguid)
        {
            return queryable.FirstOrDefault(s => s.Rowguid == rowguid);
        }
    }
}

