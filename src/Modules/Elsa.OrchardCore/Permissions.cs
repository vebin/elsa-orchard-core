﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrchardCore.Security.Permissions;

namespace Elsa.OrchardCore
{
    public class Permissions : IPermissionProvider
    {
        public static readonly Permission ManageWorkflows = new Permission("ManageElsaWorkflows", "Manage Elsa workflows", isSecurityCritical: true);

        public Task<IEnumerable<Permission>> GetPermissionsAsync()
        {
            return Task.FromResult(new[] { ManageWorkflows }.AsEnumerable());
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrator",
                    Permissions = new[] { ManageWorkflows }
                }
            };
        }
    }
}
