using Galaxy.Base.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;
using Galaxy.Base.Domain.DAL;
using NHibernate.Mapping.ByCode;

namespace DependencyInjection
{
    public static class UnitOfWorkHelper
    {
        public static bool IsRepositoryMethod(MethodInfo methodInfo)
        {
            return IsRepositoryClass(methodInfo.DeclaringType);
        }

        public static bool IsRepositoryClass(Type type)
        {
            return type.BaseType.Name==typeof(Repository<>).Name;
        }

        public static bool HasUnitOfWorkAttribute(MethodInfo methodInfo)
        {
            bool x;
            x =methodInfo.IsDefined(typeof(UnitOfWorkAttribute), true);
            return x;
        }
    }
}
