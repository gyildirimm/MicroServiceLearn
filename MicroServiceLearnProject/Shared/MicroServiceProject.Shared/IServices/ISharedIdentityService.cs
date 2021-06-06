using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceProject.Shared.IServices
{
    public interface ISharedIdentityService
    {
        public string GetUserId { get; }
    }
}
