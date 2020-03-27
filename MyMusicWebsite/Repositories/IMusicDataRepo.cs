using MyMusicWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicWebsite.Repositories
{
    public interface IMusicDataRepo
    {
        Task<List<Artist>> GetArtists();
    }
}
