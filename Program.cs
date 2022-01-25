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
                    .AsNoTracking()
                    .Skip(skip)
                    .Take(take)
                    .ToList();
    return users;

}