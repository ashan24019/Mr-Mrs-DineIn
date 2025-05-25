using System.Linq.Expressions;

namespace Mr_and_Mrs_DineIn.Models
{
    public class QueryOptions<T> where T : class
    {
        public Expression<Func<T, Object>> OrderBy { get; set; } = null!;
        public Expression<Func<T, bool>> Where { get; set; } = null!;

        private string[] includes = Array.Empty<string>();

        public string Includes
        {
            set => includes = value.Replace("","").Split(',');
        }

        public string[] GetIncludes() => includes;

        public bool HasWhere => Where != null;

        public bool HasOrderBy => OrderBy != null;
    }
}