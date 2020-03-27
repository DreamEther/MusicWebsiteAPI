using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMusicWebsite.Models;

namespace MyMusicWebsite.Repositories
{
    public class MusicDataRepo: IMusicDataRepo
    {
        private MyDbContext _context;

        public MusicDataRepo(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Artist>> GetArtists()
        {
            var artists = await _context.Artists.ToListAsync();
            return artists;
        }
    }
}
