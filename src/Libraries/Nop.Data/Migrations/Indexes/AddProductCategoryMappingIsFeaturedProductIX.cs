﻿using FluentMigrator;
using Nop.Core.Domain.Catalog;
using Nop.Data.Extensions;

namespace Nop.Data.Migrations.Indexes
{
    [NopMigration("2019/12/19 11:35:09:1647937")]
    public class AddProductCategoryMappingIsFeaturedProductIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            this.AddIndex("IX_Product_Category_Mapping_IsFeaturedProduct", NopMappingDefaults.ProductCategoryTable,
                i => i.Ascending(), nameof(ProductCategory.IsFeaturedProduct));
        }

        #endregion
    }
}