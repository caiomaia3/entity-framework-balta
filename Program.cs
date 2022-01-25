// See https://aka.ms/new-console-template for more information
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using (BlogDataContext context = new())
{
    Console.WriteLine("");
    context.Add(new User
    {
        Bio = "9x Microsoft MVP",
        Email = "andre@balta.io",
        GitHub = "andrebaltieri",
        Image = "https://balta.io",
        Name = "André Balta",
        PasswordHash = "1234",
        Slug = "andre-baltieri"
    });
    context.SaveChanges();
}
Console.WriteLine("Programa finalizado.");