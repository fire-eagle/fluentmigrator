using FluentMigrator.Builders.Alter;
using FluentMigrator.Builders.Create;
using FluentMigrator.Builders.IfDatabase;
using FluentMigrator.Builders.Insert;
using FluentMigrator.Builders.Rename;
using FluentMigrator.Builders.Schema;
using FluentMigrator.Builders.Update;

namespace FluentMigrator.Builders.ForEach
{
   public interface IForEachFederationExpressionBuilder
   {
      IAlterExpressionRoot Alter { get; }
      ICreateExpressionRoot Create { get; }
      IRenameExpressionRoot Rename { get; }
      IInsertExpressionRoot Insert { get; }
      ISchemaExpressionRoot Schema { get; }
      IUseExpressionRoot Use { get; }
      IIfDatabaseExpressionRoot IfDatabase(params string[] databaseType);
   }
}