namespace FluentMigrator.Builders.Update
{
   public interface IUseFederationSyntax
   {
      IUseFederationSyntax Name(string name);
      IUseFederationSyntax WithFiltering(bool filter);
      IUseFederationSyntax DistributionName (string name);
      IUseFederationSyntax Root ();
   }
}