using asp_hw_3.Models;
using System.Text.Json;
using System.Xml.Serialization;

namespace asp_hw_3.Services
{
    public class NoteService
    {
        private const string FilePath = "notes.json";
        private const string FilePathXML = "notes.xml";

        public void SaveNotesToJson(List<NoteModel> notes)
        {
            string json = JsonSerializer.Serialize(notes);
            File.WriteAllText(FilePath, json);
        }

        public List<NoteModel> LoadNotesFromJson()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<NoteModel>>(json);
            }
            return new List<NoteModel>();
        }

        // Збереження масиву заміток у файл у форматі XML
        public void SaveNotesToXml(List<NoteModel> notes)
        {
            using (StreamWriter writer = new StreamWriter(FilePathXML))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<NoteModel>));
                serializer.Serialize(writer, notes);
            }
        }

        // Завантаження масиву заміток з файлу у форматі XML
        public List<NoteModel> LoadNotesFromXml()
        {
            if (File.Exists(FilePathXML))
            {
                using (StreamReader reader = new StreamReader(FilePathXML))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<NoteModel>));
                    return (List<NoteModel>)serializer.Deserialize(reader);
                }
            }
            return new List<NoteModel>();
        }
    }
}
