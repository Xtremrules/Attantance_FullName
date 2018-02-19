using System.Linq;
using System.Web.Mvc;

namespace Attantance_FullName.Models
{
    public static class AppHelper
    {
        private static AppDbContext db = new AppDbContext();

        /// <summary>
        /// Require Username
        /// </summary>
        /// <param name="html"></param>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public static string FullName(this HtmlHelper html, string UserName)
        {
            var query = "SELECT TOP 1 FirstName ', ' LastName FROM Users WHERE username = @p1";
            var name = db.Database.SqlQuery<string>(query, UserName).First();
            return name;
        }

        /// <summary>
        /// Require UserId
        /// </summary>
        /// <param name="html"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static string FullName_(this HtmlHelper html, string userId)
        {
            var query = "SELECT TOP 1 FirstName ', ' LastName FROM Users WHERE UserId = @p1";
            var username = db.Database.SqlQuery<string>(query, userId).First();
            return username;
        }
    }
}