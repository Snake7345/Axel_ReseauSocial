using Axel_ReseauSocial.Api.Domains.Commands;
using Axel_ReseauSocial.Api.Domains.Commands.Contenus;
using Axel_ReseauSocial.Api.Domains.Queries.Contenus;
using Axel_ReseauSocial.Api.Domains.Queries.Pvs;
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
    public interface IContenuRepository : IQueryHandler<GetAllContenusQuery, IEnumerable<Contenu>>,
        IQueryHandler<GetOneContenuQuery, Contenu?>,
        ICommandHandler<CreateContenuCommand>
    {
    }
}
