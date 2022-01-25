// See https://aka.ms/new-console-template for more information
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using BlogDataContext context = new();
var users = GetUsers(context, 0, 25);

Console.WriteLine("Programa finalizado.");

static List<User> GetUsers(BlogDataContext context, int skip = 0, int take = 25)
{
    var users = context
                    .Users
                    .Include(x => x.Roles)
                        .ThenInclude(x => x.Users)
                            .ThenInclude(x => x.Roles) // Sem limite
                    .ToList();

    return users;

}