
using System.ComponentModel.Design;

namespace Infrastructure.Services;

internal class JsonFileService
{
    private readonly string _filePath;


    public void SaveToFile()
    {
        if (!File.Exists(_filePath))
        {
            Console.WriteLine("File does not exist");
        }
        else
        {
            Console.WriteLine("File exists");
        }
    }
}
