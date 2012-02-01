using FluentMigrator.Expressions;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.Update
{
    public class UseExpressionRoot : IUseExpressionRoot
    {
        private readonly IMigrationContext _context;

        public UseExpressionRoot(IMigrationContext context)
        {
            _context = context;
        }

        public IUseFederationSyntax Federation()
        {
           return Federation (null);
        }

        public IUseFederationSyntax Federation(string name)
        {
            var expression = new UseFederationExpression { Name = name };
            _context.Expressions.Add(expression);
            return new UseFederationExpressionBuilder(expression, _context);
        }
    }
}
