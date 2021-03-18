using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BIMPlatform.Domain.Projects
{
    public interface IProjectManager
    {
        Task<Project> CreateAsync([NotNull] Project project);
        Task<Project> UpdateAsync([NotNull] int key, [NotNull] Project project);
        Task<Project> GetAsync([NotNull] int key);
        Task<Project> GetByNameAsync([NotNull] string name);
        Task RemoceAsync([NotNull] int key);
    }
}
