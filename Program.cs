// See https://aka.ms/new-console-template for more information
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using BlogDataContext context = new();

var users = context.Users;

foreach (var user in users)
{
    foreach (var role in user.Roles)
    {
        //Lazy loading
    }
}

var users2 = context.Users.Include(x => x.Roles);
foreach (var user in users2)
{
    foreach (var role in user.Roles)
    {
        //Eager loading
    }
}
Console.WriteLine("Programa finalizado.");