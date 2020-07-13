namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerBirthDate1 : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set BirthDate = '12-04-" +
                "1989' Where Id = 1");
            
        }
        
        public override void Down()
        {
        }
    }
}
