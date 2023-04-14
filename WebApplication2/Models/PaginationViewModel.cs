namespace WebApplication2.Models
{
    public class PaginationViewModel<T>
    {
        public List<T> Items { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public String SearchTerm { get; set; }
    }
}
