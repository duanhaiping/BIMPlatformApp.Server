using BIMPlatformApplication.Application.Domain.Users;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BIMPlatform.Application.Abstractions.Users
{
    public interface IUserService
    {
        Task CreateAsync([NotNull] object user);
        Task UpdateAsync([NotNull] int key, object user);
        Task DeleteAsync([NotNull] int key);
        Task GetAsync([NotNull] int key);
    }
}
