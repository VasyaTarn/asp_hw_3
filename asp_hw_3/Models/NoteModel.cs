namespace asp_hw_3.Models
{
    public class NoteModel
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string[] Tags { get; set; }

        public NoteModel() {}
        public NoteModel(string name, string text, DateTime date, string[] tags)
        {
            Name = name;
            Text = text;
            Date = date;
            Tags = tags;
        }
    }
}
