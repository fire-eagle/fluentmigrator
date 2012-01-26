namespace FluentMigrator.Builders.Create.Federation
{
    public interface ICreateFederationSyntax
    {
        ICreateFederationSyntax Name(string name);

        ICreateFederationSyntax DistributionName(string distributionName);

        ICreateFederationSyntax DataType(string dataType);

        ICreateFederationSyntax Partition(string partition);
    }
}