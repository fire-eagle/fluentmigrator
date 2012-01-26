using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FluentMigrator.Runner.Processors.SqlServer
{
    class AzureProcessor : SqlServerProcessor
    {
        public AzureProcessor (IDbConnection connection, IMigrationGenerator generator, IAnnouncer announcer, IMigrationProcessorOptions options, IDbFactory factory)
            : base(connection, generator, announcer, options, factory)
        {
        }

        public override string DatabaseType
        {
            get { return "Azure"; }
        }
    }
}
