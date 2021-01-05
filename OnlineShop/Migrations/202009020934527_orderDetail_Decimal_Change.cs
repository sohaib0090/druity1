﻿namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderDetail_Decimal_Change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderDetail", "UnitSalePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderDetail", "UnitSalePrice", c => c.Int(nullable: false));
        }
    }
}
