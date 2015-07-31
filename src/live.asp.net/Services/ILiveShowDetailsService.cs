﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using live.asp.net.Models;

namespace live.asp.net.Services
{
    public interface ILiveShowDetailsService
    {
        Task<LiveShowDetails> LoadAsync();

        Task SaveAsync(LiveShowDetails liveShowDetails);
    }
}
