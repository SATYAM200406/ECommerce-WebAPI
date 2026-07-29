using Microsoft.AspNetCore.Http.HttpResults;

namespace MySecondWebApi.Models
{
    public class QueryParameters
    {

        //Created for "Pagination"
        const int _maxSize = 100;
        private int _size = 50;

        public int Page {  get; set; } =1;

        public int Size
        {
            get { return _size; }
            set
            {
                _size=Math.Min(_maxSize, value);
            }
        }
    }
}
