using AutoMapper;
using FirstAPI.DAL;
using FirstAPI.DTOs.Languages;
using FirstAPI.Services.Abstract;
using FirstAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Services.Implements
{
    public class LanguageService(TabuDBContext _context, IMapper _mapper) : ILanguageService
    {
        public async Task CreateAsync(LanguageCreateDTO dto)
        {
            var lang = _mapper.Map<Language>(dto);
            await _context.Languages.AddAsync(lang);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<LanguageGetDto>> GetAllAsync()
        {
            var langs = await _context.Languages.ToListAsync();
            return _mapper.Map<IEnumerable<LanguageGetDto>>(langs);
        }

        Task ILanguageService.UpdateAsync(string code, LanguageCreateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
