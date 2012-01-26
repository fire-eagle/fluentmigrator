using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Expressions
{
    public class DeleteFederationExpression : MigrationExpressionBase
    {
        public string Name { get; set; }

        public override void CollectValidationErrors(ICollection<string> errors)
        {
            if (String.IsNullOrEmpty(Name))
                errors.Add(ErrorMessages.FederationNameCannotBeNullOrEmpty);
        }

        public override void ExecuteWith(IMigrationProcessor processor)
        {
            processor.Process(this);
        }

        public override string ToString()
        {
            return base.ToString() + Name;
        }
    }
}
