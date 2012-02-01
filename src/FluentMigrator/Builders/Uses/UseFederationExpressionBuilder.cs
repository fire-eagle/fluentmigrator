#region License
// 
// Copyright (c) 2007-2009, Sean Chambers <schambers80@gmail.com>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using FluentMigrator.Expressions;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.Update
{
    public class UseFederationExpressionBuilder : IUseFederationSyntax
    {
        private readonly UseFederationExpression _expression;
        private readonly IMigrationContext _context;

        public UseFederationExpressionBuilder(UseFederationExpression expression, IMigrationContext context)
        {
            _context = context;
            _expression = expression;
        }

        public IUseFederationSyntax Name(string name)
        {
            _expression.Name = name;
            return this;
        }

        public IUseFederationSyntax DistributionName(string distributionName)
        {
           _expression.DistributionName = distributionName;
           return this;
        }

        public IUseFederationSyntax WithFiltering(bool filter)
        {
            _expression.Filtering = filter;
            return this;
        }

       public IUseFederationSyntax Root()
       {
          _expression.UseRoot = true;
          return this;
       }
    }
}
