using FluentMigrator.Expressions;

namespace FluentMigrator.Builders.Create.Federation
{
    public class CreateFederationExpressionBuilder : ExpressionBuilderBase<CreateFederationExpression>, ICreateFederationSyntax
    {
        public CreateFederationExpressionBuilder(CreateFederationExpression expression)
            : base(expression)
        {
        }

        public ICreateFederationSyntax Name (string name)
        {
            Expression.FederationDefinition.Name = name;
            return this;
        }

        public ICreateFederationSyntax DistributionName (string distributionName)
        {
            Expression.FederationDefinition.DistributionName = distributionName;
            return this;
        }

        public ICreateFederationSyntax DataType (string dataType)
        {
            Expression.FederationDefinition.DataType = dataType;
            return this;
        }

        public ICreateFederationSyntax Partition (string partition)
        {
            Expression.FederationDefinition.Partition = partition;
            return this;
        }
    }
}