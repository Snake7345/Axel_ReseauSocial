using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Roles
{
    public class UpdateRoleCommand : ICommand
    {
        public int IdRole { get; init; }
        public string Denomination { get; init; }

        public UpdateRoleCommand(int idRole, string denomination)
        {
            IdRole = idRole;
            Denomination = denomination;
        }

    }
}
