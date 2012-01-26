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

        public string FederateTable { get { return "FEDERATED ON ({0} = {1})"; } }

        public override string CreateTable { get { return "{0} ({1})"; } }

        public override string Generate(CreateFederationExpression expression)
        {
            //"The CREATE FEDERATION statement must be the only statement in the batch" - MSDN docs
            return string.Format("{0} CREATE FEDERATION {1} {2}", BATCH, expression.FederationDefinition.ToString(), BATCH);
        }

        public override string Generate(DeleteFederationExpression expression)
        {
            return string.Format("DROP FEDERATION {0}", expression.Name);
        }

        public override string Generate(CreateTableExpression expression)
        {
            string FederatedOn = "";
            if (!(string.IsNullOrEmpty(expression.FederationDistribution) || string.IsNullOrEmpty(expression.FederationColumn)))
                FederatedOn = string.Format (FederateTable, expression.FederationDistribution,
                                             expression.FederationColumn);

            return string.Format("{0} {1}", base.Generate(expression), FederatedOn);
        }

        private const string BATCH = "\nGO\n";
    }
}
