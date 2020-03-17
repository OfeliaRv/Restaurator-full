using Restaurator.Data;
using Restaurator.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Restaurator.Injection
{
    public interface IAuth
    {
        User User { get; }
    }

    public class Auth : IAuth
    {
        private readonly RestauratorDbContext _context;
        private readonly IHttpContextAccessor _accessor;

        public Auth(RestauratorDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public User User
        {
            get
            {
                string token = string.Empty;

                bool hasHeader = this._accessor.HttpContext.Request.Cookies.TryGetValue("token", out token);

                if (!hasHeader)
                {
                    return null;
                }

                User user = _context.Users.Include("Comment").FirstOrDefault(c => c.Token == token);

                if (user == null)
                {
                    return null;
                }

                return user;
            }
        }
    }
}