using Buisness.Service;

namespace Buisness.Managers;

public class UserManager
{
    private readonly FileService _fileService;

    public UserManager(string filePath, string filePath)
    {
        _filerService = new FileService(filePath);
    }
}
