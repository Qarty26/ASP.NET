using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.HashtagService
{
    public interface IHashtagService
    {
        List<HashtagDTO> GetAllHashtags();
        HashtagDTO GetHashtagById(Guid id);
        Task CreateHashtag(HashtagCreateDTO tag);
        void UpdateHashtag(HashtagDTO tag);
        bool DeleteHashtagById(Guid id);
    }
}
