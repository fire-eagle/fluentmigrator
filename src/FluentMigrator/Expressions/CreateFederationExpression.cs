using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentMigrator.Model;

namespace FluentMigrator.Expressions
{
   public class CreateFederationExpression : MigrationExpressionBase
   {
        public virtual FederationDefinition FederationDefinition { get; set; }

        public CreateFederationExpression()
        {
            FederationDefinition = new FederationDefinition();
        }

        public override void CollectValidationErrors(ICollection<string> errors)
        {
            FederationDefinition.CollectValidationErrors (errors);
        }

        public override void ExecuteWith(IMigrationProcessor processor)
        {
            processor.Process(this);
        }

        public override string ToString()
        {
            return base.ToString() + FederationDefinition.ToString();
        }
   }
}
