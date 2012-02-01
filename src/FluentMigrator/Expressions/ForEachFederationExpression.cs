using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Expressions
{
   public class ForEachFederationExpression : MigrationExpressionBase
   {
      public IMigrationContext Context { get; set; }
      public string Federation { get; set; }

      public override void CollectValidationErrors(ICollection<string> errors)
      {
         if (String.IsNullOrEmpty(Federation))
            errors.Add(ErrorMessages.FederationNameCannotBeNullOrEmpty);

         if (Context == null)
            errors.Add (ErrorMessages.ForEachContextCannotBeNull);
      }

      public override void ExecuteWith(IMigrationProcessor processor)
      {
         processor.Process(this);
      }
   }
}
