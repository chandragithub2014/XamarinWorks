using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using XamarinPractice.model;

namespace XamarinPractice.network
{
    public interface RetroInterface
    {
        [Get("/users")]
        Task<List<PostUsers>> GetUserInfo();
    }
}
