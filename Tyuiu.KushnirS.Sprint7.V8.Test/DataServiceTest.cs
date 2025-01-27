using Tyuiu.KushnirS.Sprint7.V8.Lib;
namespace Tyuiu.KushnirS.Sprint7.V8.Test
{

    public sealed class DataServiceTest
    {

        public void FileLoadedTest()
        {
            var ds = new DataService();
            string path = @"C:\DataSprint7\AutoTest.csv";
            List<string[]> wait = new List<string[]>();
            wait.Add(new string[] { "98", "�344��", "Porshe", "��������", "� ������", "70", "40", "60" });
            wait.Add(new string[] { "54", "45���8", "�����", "��������� ��", "���������", "40", "200", "300" });
            CollectionAssert.AreEqual(wait, ds.LoadDataFromFile(path));
        }
    }
}
