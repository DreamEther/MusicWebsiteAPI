using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using MyMusicWebsite.Repositories;
using MyMusicWebsite.Models;

namespace MyMusicWebsite.MyMusicWebsite.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class MusicDataController : ControllerBase
    {
        private readonly IMusicDataRepo _repo;
        private readonly ILogger<MusicDataController> _logger;
        public MusicDataController(IMusicDataRepo repo)
        {
            _repo = repo;
        }

   

        public MusicDataController(ILogger<MusicDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artist>>> GetArtists()
        {
            var artists = await _repo.GetArtists();
            return artists;
        }
    }
}
