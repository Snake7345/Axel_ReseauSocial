using Axel_ReseauSocial.Api.Domains.Commands;
using Axel_ReseauSocial.Api.Domains.Commands.Commentaires;
using Axel_ReseauSocial.Api.Domains.Queries.Commentaires;
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
    public interface ICommentaireRepository : IQueryHandler<GetAllCommentairesQuery, IEnumerable<Commentaire>>,
        IQueryHandler<GetOneCommentaireQuery, Commentaire?>,
        ICommandHandler<CreateCommentaireCommand>
    {
    }
}
