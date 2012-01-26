using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using FluentMigrator.Infrastructure;

namespace FluentMigrator.Model
{
    public class FederationDefinition : ICloneable, ICanBeValidated
    {
        public virtual string Name { get; set; }
        public virtual string DistributionName { get; set; }
        public virtual string Partition { get; set; }
        public virtual string DataType { get; set; }

        public FederationDefinition()
        {
            Partition = "RANGE";
        }

        public virtual void CollectValidationErrors(ICollection<string> errors)
        {
            if (String.IsNullOrEmpty(Name))
                errors.Add(ErrorMessages.FederationNameCannotBeNullOrEmpty);

            if (String.IsNullOrEmpty(DistributionName))
                errors.Add(ErrorMessages.DistributionNameCannotBeNullOrEmpty);

            if (String.IsNullOrEmpty(Partition))
                errors.Add(ErrorMessages.FederationPartitionCannotBeNullOrEmpty);

            if (String.IsNullOrEmpty(DataType) || (string.Compare(DataType, "INT", true) != 0 &&
                                                   string.Compare(DataType, "BIGINT", true) != 0 &&
                                                   string.Compare(DataType, "UNIQUEIDENTIFIER", true) != 0 &&
                                                   !Regex.IsMatch(DataType, @"^VARBINARY\(([0-8]?[0-9]?[0-9]|900)\)$")))
                errors.Add(ErrorMessages.ImproperFederationDataType);
        }

        public object Clone()
        {
            return new FederationDefinition
            {
                Name = Name,
                DistributionName = DistributionName,
                Partition = Partition,
                DataType = DataType
            };
        }

        public string ToString()
        {
            return string.Format("{0} ({1} {2} {3})", Name, DistributionName, DataType, Partition);
        }
    }
}