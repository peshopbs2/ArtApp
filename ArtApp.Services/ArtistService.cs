using ArtApp.Data.Entities;
using ArtApp.Data.Repositories.Abstractions;
using ArtApp.Services.Abstractions;
using ArtApp.Services.DTOs;
using AutoMapper;

namespace ArtApp.Services
{
    public class ArtistService : IArtistService
    {
        private readonly ICrudRepository<Artist> _repository;
        private readonly IMapper _mapper;
        public ArtistService(ICrudRepository<Artist> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(ArtistDTO model)
        {
            var artist = _mapper.Map<Artist>(model);

            await _repository.AddAsync(artist);
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _repository.DeleteByIdAsync(id);
        }

        public async Task<List<ArtistDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ArtistDTO>>(
                await _repository.GetAllAsync()
            );
        }

        public async Task<List<ArtistDTO>> GetArtistByNameAsync(string name)
        {
            var artists = await _repository.GetAsync(item => item.FirstName.Contains(name) || item.LastName.Contains(name));
            return _mapper.Map<List<ArtistDTO>>(artists);
        }

        public async Task<ArtistDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ArtistDTO>(await _repository.GetByIdAsync(id));
        }

        public async Task UpdateAsync(ArtistDTO model)
        {
            var artist = _mapper.Map<Artist>(model);
            await _repository.UpdateAsync(artist);
        }
    }
}
