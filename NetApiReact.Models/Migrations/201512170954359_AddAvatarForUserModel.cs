namespace NetApiReact.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvatarForUserModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Avatr", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Avatr");
        }
    }
}
