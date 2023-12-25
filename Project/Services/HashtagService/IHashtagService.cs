using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.HashtagService
{
    public interface IHashtagService
    {
        List<HashtagDTO> GettAllHashtags();
        HashtagDTO GetHashtagById(Guid id);
        bool DeleteHashtagById(Guid id);
    }
}
