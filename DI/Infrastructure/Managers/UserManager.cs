
using Infrastructure.Models;
using Infrastructure.Services;

namespace Infrastructure.Managers;

internal class UserManager
{
    private readonly JsonFileService _FileService = new JsonFileService();

    public void CreateUser(User user)
    {
        _FileService.SaveToFile();
    }
}
