// See https://aka.ms/new-console-template for more information
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using (BlogDataContext context = new())
{
    Console.WriteLine("");

    User user = new()
    {
        Name = "André Baltieri",
        Slug = "andrebaltinha",
        Email = "and@balta.io",
        Bio = "Histórias",
        Image = "https://balta.io",
        PasswordHash = "123456789"
    };

    Category category = new()
    {
        Name = "Backend",
        Slug = "backend"
    };

    Post post = new()
    {
        Author = user,
        Category = category,
        Body = "<p>Hello world</p>",
        Slug = "comecando-com-ef-core",
        Summary = "Neste artigo vamos aprender EF core",
        Title = "Começando com EF core",
        CreateDate = DateTime.Now,
        LastUpdateDate = DateTime.Now,
    };
    context.Posts.Add(post);
    context.SaveChanges();
}
Console.WriteLine("Programa finalizado.");