namespace Tyuiu.KushnirS.Sprint7.V8.Lib
{
    public class DataService
    {
        public List<string[]> LoadDataFromFile(string path)
        {
            // Проверка наличия файла
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            List<string[]> strings = new List<string[]>();

            // Использование StreamReader для чтения файла
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    strings.Add(line.Split(';'));
                }
            }

            return strings;
        }
    }
}
