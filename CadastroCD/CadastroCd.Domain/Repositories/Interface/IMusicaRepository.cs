﻿using Cd.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cd.Domain.Repositories.Interface
{
    public interface IMusicaRepository
    {
        int AddMusica(Musica musica);
        Task<List<Musica>> GetAll();
        Task<List<Musica>> GetMusicaIdCd(int id);
    }
}
