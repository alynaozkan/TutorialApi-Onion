using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TutorialApi.Domain.Common;

namespace TutorialApi.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T>where T : class, IEntityBase, new() 
    {
        
    }
}
