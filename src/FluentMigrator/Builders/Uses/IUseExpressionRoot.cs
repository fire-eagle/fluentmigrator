using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.Update
{
   public interface IUseExpressionRoot : IFluentSyntax
   {
      IUseFederationSyntax Federation();
      IUseFederationSyntax Federation(string name);
   }
}