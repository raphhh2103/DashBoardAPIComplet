namespace BLL.Models
{
    public class ContentBLL
    {

        public int Id { get; set; }

        public string Text { get; set; }

        public BoardBLL TitleBoard { get; set; }
    }
}