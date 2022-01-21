// See https://aka.ms/new-console-template for more information
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using (BlogDataContext context = new())
{
    Console.WriteLine("");
    // context.Add(new User
    // {
    //     Bio = "9x Microsoft MVP",
    //     Email = "andre@balta.io",
    //     Image = "https://balta.io",
    //     Name = "André Balta",
    //     PasswordHash = "1234",
    //     Slug = "andre-baltieri"
    // });
    // context.SaveChanges();
    User? user = context
        .Users
        .FirstOrDefault();

    Post post = new()
    {
        Author = user,
        Body = "Meu artigo",
        Category = new Category
        {
            Name = "Backend",
            Slug = "backend"
        },
        CreateDate = System.DateTime.Now,
        /// LastUpdateDate
        Slug = "meu-artigo",
        Summary = "Neste artigo vamos conferir...",
        /// Tags = 
        Title = "Meu Artigo"
    };
    context.Add(post);
    context.SaveChanges();
}
Console.WriteLine("Programa finalizado.");