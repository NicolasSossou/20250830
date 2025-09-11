

namespace Data
{
    public class DataRepository

    {
        private readonly string _filePath;
        private readonly List<string> _lines = new();



        public DataRepository(string filePath) => _filePath = filePath;
    }
    
}
