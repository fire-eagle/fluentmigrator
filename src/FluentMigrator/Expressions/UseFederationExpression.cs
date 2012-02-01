using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Expressions
{
   public class UseFederationExpression : MigrationExpressionBase
   {
      public string Name { get; set; }
      public string DistributionName { get; set; }
      public bool Filtering { get; set; }
      public bool UseRoot { get; set; }
      public string DistributionValue { get; set; }

      public override void ExecuteWith (IMigrationProcessor processor)
      {
         processor.Process(this);
      }

      public override void CollectValidationErrors (ICollection<string> errors)
      {
         if (String.IsNullOrEmpty(Name))
            errors.Add(ErrorMessages.FederationNameCannotBeNullOrEmpty);
      }
   }
}
