namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name = 'Pay as you Go' where Id = 1");
            Sql("Update MembershipTypes Set Name = 'Monthly' where Id = 2");
            Sql("Update MembershipTypes Set Name = 'Yearly' where Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
