namespace MarDom.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "EmpresaId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "EmpresaId");
        }
    }
}
