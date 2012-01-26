using FluentMigrator.Runner.Generators.SqlServer;

namespace FluentMigrator.Runner.Processors.SqlServer
{
   public class AzureProcessorFactory : MigrationProcessorFactory
   {
      public override IMigrationProcessor Create(string connectionString, IAnnouncer announcer, IMigrationProcessorOptions options)
      {
         var factory = new SqlServerDbFactory();
         var connection = factory.CreateConnection(connectionString);
         return new AzureProcessor(connection, new AzureGenerator(), announcer, options, factory);
      }
   }
}