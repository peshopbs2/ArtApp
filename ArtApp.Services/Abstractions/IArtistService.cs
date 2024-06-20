using ArtApp.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtApp.Services.Abstractions
{
    public interface IArtistService
    {
        Task<List<ArtistDTO>> GetAllAsync();
        Task<ArtistDTO> GetByIdAsync(int id);
        Task<List<ArtistDTO>> GetArtistByNameAsync(string name);
        Task AddAsync(ArtistDTO model);
        Task UpdateAsync(ArtistDTO model);
        Task DeleteByIdAsync(int id);

    }
}
