using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.ServiceLocation;

using Happy.Utils;

namespace Happy.ServiceLocation
{
    /// <summary>
    /// 基于AppDomain的实现，只用于测试环境。
    /// </summary>
    public sealed class AppDomainServiceLocator : ServiceLocatorImplBase
    {
        /// <inheritdoc />
        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            return AppDomain.CurrentDomain.CreateConcreteDescendentInstances(serviceType);
        }

        /// <inheritdoc />
        protected override object DoGetInstance(Type serviceType, string key)
        {
            return AppDomain.CurrentDomain.CreateConcreteDescendentInstance(serviceType);
        }
    }
}
