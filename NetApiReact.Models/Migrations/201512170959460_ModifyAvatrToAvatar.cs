namespace NetApiReact.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyAvatrToAvatar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Avatar", c => c.String(maxLength: 250));
            DropColumn("dbo.User", "Avatr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Avatr", c => c.String(maxLength: 250));
            DropColumn("dbo.User", "Avatar");
        }
    }
}
