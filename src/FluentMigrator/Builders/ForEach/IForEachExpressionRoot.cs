using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.ForEach
{
   public interface IForEachExpressionRoot : IFluentSyntax
   {
      IForEachFederationExpressionBuilder Federation(string name);
   }
}