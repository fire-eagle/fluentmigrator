using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentMigrator.Builders.Alter;
using FluentMigrator.Builders.Create;
using FluentMigrator.Builders.Execute;
using FluentMigrator.Builders.IfDatabase;
using FluentMigrator.Builders.Insert;
using FluentMigrator.Builders.Rename;
using FluentMigrator.Builders.Schema;
using FluentMigrator.Builders.Update;
using FluentMigrator.Expressions;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.ForEach
{
   class ForEachFederationExpressionBuilder : IForEachFederationExpressionBuilder
   {
      private ForEachFederationExpression _expression;

      public ForEachFederationExpressionBuilder(IMigrationContext context, ForEachFederationExpression expression)
      {
         _expression = expression;
         expression.Context = new MigrationContext (context.Conventions, context.QuerySchema,
                                                    context.MigrationAssembly,
                                                    context.ApplicationContext);
      }

      public IAlterExpressionRoot Alter
      {
         get { return new AlterExpressionRoot(_expression.Context); }
      }

      public ICreateExpressionRoot Create
      {
         get { return new CreateExpressionRoot(_expression.Context); }
      }

      public IRenameExpressionRoot Rename
      {
         get { return new RenameExpressionRoot(_expression.Context); }
      }

      public IInsertExpressionRoot Insert
      {
         get { return new InsertExpressionRoot(_expression.Context); }
      }

      public ISchemaExpressionRoot Schema
      {
         get { return new SchemaExpressionRoot(_expression.Context); }
      }

      public IExecuteExpressionRoot Execute
      {
         get { return new ExecuteExpressionRoot(_expression.Context); }
      }

      public IUseExpressionRoot Use
      {
         get { return new UseExpressionRoot(_expression.Context); }
      }

      public IIfDatabaseExpressionRoot IfDatabase(params string[] databaseType)
      {
         return new IfDatabaseExpressionRoot(_expression.Context, databaseType);
      }
   }
}
