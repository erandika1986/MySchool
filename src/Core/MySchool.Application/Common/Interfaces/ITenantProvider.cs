using MySchool.Domain.Entities.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Application.Common.Interfaces
{
    public interface ITenantProvider
    {
        long GetTenantId();
        Tenant GetTenant();
    }
}
