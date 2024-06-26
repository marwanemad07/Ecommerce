﻿
namespace E_Commerce.BLL.Services.Implemntations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository brandRepository,
            IMapper mapper) 
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }
        public async Task<List<BrandDto>> GetBrandsAsync()
        {
            var brands = await _brandRepository.GetBrandsAsync();
            return _mapper.Map<List<Brand>, List<BrandDto>>(brands); 
        }
    }
}
