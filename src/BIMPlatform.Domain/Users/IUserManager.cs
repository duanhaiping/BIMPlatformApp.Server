using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BIMPlatformApplication.Application.Domain.Users
{
    public interface IUserManager
    {
        Task<User> CreateAsync([NotNull] User user);

        Task ChangeNameAsync([NotNull] User user, [NotNull] string name);
    }
}
