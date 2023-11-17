using Lab3_2.Models;
using System.Globalization;

namespace Lab3_2.Helpers.Extensions
{
    public static class OnlyActive
    {
        public static IQueryable<User> GetActiveUsers(this IQueryable<User> query)
        {
            return query.Where(x => !x.IsDeleted);
        }
    }
}
