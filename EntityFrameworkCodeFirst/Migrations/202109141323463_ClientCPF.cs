namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientCPF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "CPF", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "CPF");
        }
    }
}
