using Axel_ReseauSocial.Api.Domains.Commands;
using Axel_ReseauSocial.Api.Domains.Queries;
using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Repositories
{
    public interface IUtilisateurRepository : ICommandHandler<RegisterUtilisateurCommand>,
        IQueryHandler<GetAllUtilisateursQuery,IEnumerable<Utilisateur>>,
        IQueryHandler<GetOneUtilisateurQuery,Utilisateur?>
    {
    }
}
