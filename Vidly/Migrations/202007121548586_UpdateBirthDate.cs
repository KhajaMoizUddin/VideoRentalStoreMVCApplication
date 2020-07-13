namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set BirthDate = '12-04-" +
                "1989' Where Id = 1");
        }

        public override void Down()
        {
        }
    }
}
