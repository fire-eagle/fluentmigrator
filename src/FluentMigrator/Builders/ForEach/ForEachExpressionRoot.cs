using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentMigrator.Expressions;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.ForEach
{
   class ForEachExpressionRoot : IForEachExpressionRoot
   {
        private readonly IMigrationContext _context;

        public ForEachExpressionRoot(IMigrationContext context)
        {
            _context = context;
        }

        public IForEachFederationExpressionBuilder Federation(string name)
        {
            var expression = new ForEachFederationExpression{Federation = name};
            _context.Expressions.Add(expression);
            return new ForEachFederationExpressionBuilder(_context, expression);
        }
   }
}
