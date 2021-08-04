using Dapper;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.StartProject
{
    public class StartProjectCommandHandler : IRequestHandler<StartProjectCommand, Unit>
    {
        private readonly IProjectRepository _iprojectRepository;
        public StartProjectCommandHandler(IProjectRepository projectRepository)
        {
            _iprojectRepository = projectRepository;
        }

        public async Task<Unit> Handle(StartProjectCommand request, CancellationToken cancellationToken)
        {
            

            return Unit.Value;
        }
    }
}
