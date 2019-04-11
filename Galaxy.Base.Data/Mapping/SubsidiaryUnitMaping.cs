﻿using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace Galaxy.Mapping
{
    public class SubsidiaryUnitMaping : IAutoMappingOverride<SubsidiaryUnit>
    {
        public void Override(AutoMapping<SubsidiaryUnit> mapping)
        {
            mapping.Map(c => c.SubsidiaryUnitName);
            mapping.Map(c => c.Coefficient);
            mapping.References(c => c.measurement).Not.Nullable().Column("Measurement");
        }
    }
}