using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BIMPlatform.Domain.Projects
{
    public class ProjectManager : IProjectManager
    {
        public Task<Project> CreateAsync([NotNull] Project project)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetAsync([NotNull] int key)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetByNameAsync([NotNull] string name)
        {
            throw new NotImplementedException();
        }

        public Task RemoceAsync([NotNull] int key)
        {
            throw new NotImplementedException();
        }

        public Task<Project> UpdateAsync([NotNull] int key, [NotNull] Project project)
        {
            throw new NotImplementedException();
        }
    }
}
