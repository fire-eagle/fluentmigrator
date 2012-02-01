using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentMigrator.Builders.Create.Table
{
   public interface ICreateTableFederationSyntax : ICreateTableWithColumnSyntax
   {
      ICreateTableFederationSyntax Column(string columnName);
      ICreateTableFederationSyntax DistributionName(string distributionName);
   }
}
