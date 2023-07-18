﻿using Axel_ReseauSocial.Api.Domains.Commands.Roles;
using Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Queries.Roles;
using Axel_ReseauSocial.Api.Domains.Queries.Travails;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class RoleService : IRoleRepository
    {
        private readonly ReseauSocialDbContext _context;

        public RoleService(ReseauSocialDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Role> Execute(GetAllRolesQuery query)
        {
            return _context.Roles.ToList();
        }

        public Role? Execute(GetOneRoleQuery query)
        {
            var role = _context.Roles
                .FirstOrDefault(r => r.IdRole == query.Id);

            return role;
        }

        public Result Execute(CreateRoleCommand command)
        {
            try
            {
                Role ObjectRole = new Role()
                {
                    Denomination = command.Denomination,
                };
                _context.Roles.Add(ObjectRole);

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L\'insertion de l\'entité {nameof(Utilisateur)} a echouée");
            }

        }


    }
}
