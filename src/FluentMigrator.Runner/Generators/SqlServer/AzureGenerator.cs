using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentMigrator.Expressions;

namespace FluentMigrator.Runner.Generators.SqlServer
{
   class AzureGenerator : SqlServer2008Generator
   {
      public string CreateFederation { get { return "CREATE FEDERATION {0} ({1})"; } }

      public string UseFederation { get { return "USE FEDERATION {0}({1} = {2}) WITH RESET{3}"; } }

      public string FederationFiltering { get { return ", FILTERING={0}"; } }

      public string UseRoot { get { return "USE FEDERATION ROOT WITH RESET"; } }

      public string Batch { get { return "\nGO\n"; } }

      public string FederateTable { get { return "FEDERATED ON ({0} = {1})"; } }

      public override string CreateTable { get { return "{0} ({1})"; } }

      public override string Generate(CreateFederationExpression expression)
      {
         //"The CREATE FEDERATION statement must be the only statement in the batch" - MSDN docs
         return string.Format("CREATE FEDERATION {0}", expression.FederationDefinition.ToString());
      }

      public override string Generate(DeleteFederationExpression expression)
      {
         return string.Format("DROP FEDERATION {0}", expression.Name);
      }

      public override string Generate(CreateTableExpression expression)
      {
         string FederatedOn = "";
         if (!(string.IsNullOrEmpty(expression.Federation.DistributionName) || string.IsNullOrEmpty(expression.FederationColumn)))
         {
            FederatedOn = string.Format(FederateTable, expression.Federation.DistributionName,
                                         expression.FederationColumn);
         }

         return Wrap(string.Format("{0} {1}", base.Generate(expression), FederatedOn));
      }

      public override string Generate(UseFederationExpression expression)
      {
         if (expression.UseRoot)
         {
            return Wrap(UseRoot);
         }

         string filter = string.Format(FederationFiltering, expression.Filtering ? "ON" : "OFF");

         return Wrap(string.Format(UseFederation, expression.Name, expression.DistributionName, expression.DistributionValue ?? "1", filter));
      }


      private string Wrap(string sql)
      {
         return string.Format ("{0}{1}{2}", Batch, sql, Batch);
      }
   }
}
