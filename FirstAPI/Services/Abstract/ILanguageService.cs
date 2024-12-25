using FirstAPI.DTOs.Languages;

namespace FirstAPI.Services.Abstract;

public interface ILanguageService
{
    Task<IEnumerable<LanguageGetDto>> GetAllAsync(); 
    Task CreateAsync(LanguageCreateDTO dTO);
    Task UpdateAsync(string code, LanguageCreateDTO dto);
}
