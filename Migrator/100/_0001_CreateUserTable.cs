namespace Migrator._100;

[Migration(0001)]
public class _0001_CreateUserTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("User")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("FirstName").AsString(255).NotNullable()
            .WithColumn("LastName").AsString(255).NotNullable()
            .WithColumn("Email").AsString(500).NotNullable()
            .WithColumn("Password").AsString(255).NotNullable();    
    }
}