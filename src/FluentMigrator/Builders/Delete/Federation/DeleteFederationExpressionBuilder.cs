using FluentMigrator.Expressions;

namespace FluentMigrator.Builders.Delete.Federation
{
    public class DeleteFederationExpressionBuilder : ExpressionBuilderBase<DeleteFederationExpression>, IDeleteFederationSyntax
    {
        public DeleteFederationExpressionBuilder(DeleteFederationExpression expression)
            : base(expression)
        {
        }

        public IDeleteFederationSyntax Name (string name)
        {
            Expression.Name = name;
            return this;
        }
    }
}