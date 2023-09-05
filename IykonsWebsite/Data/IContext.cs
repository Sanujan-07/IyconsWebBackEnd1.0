using IykonsWebsite.Model;
using Microsoft.EntityFrameworkCore;

namespace IykonsWebsite.Data
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }
    }
}