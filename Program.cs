// See https://aka.ms/new-console-template for more information
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using (BlogDataContext context = new())
{
    Console.WriteLine("");
    /*
        // User user = new()
        // {
        //     Name = "André Baltieri",
        //     Slug = "andrebaltinha",
        //     Email = "and@balta.io",
        //     Bio = "Histórias",
        //     Image = "https://balta.io",
        //     PasswordHash = "123456789"
        // };

        // Category category = new()
        // {
        //     Name = "Backend",
        //     Slug = "backend"
        // };

        // Post post = new()
        // {
        //     Author = user,
        //     Category = category,
        //     Body = "<p>Hello world</p>",
        //     Slug = "comecando-com-ef-core",
        //     Summary = "Neste artigo vamos aprender EF core",
        //     Title = "Começando com EF core",
        //     CreateDate = DateTime.Now,
        //     LastUpdateDate = DateTime.Now,
        // };
        // context.Posts.Add(post);
        // context.SaveChanges();
    */

    // List<Post> posts = context
    //             .Posts
    //             .AsNoTracking()
    //             .Include(x => x.Author)
    //             .Include(x => x.Category)
    //             .OrderBy(x => x.LastUpdateDate)
    //             .ToList();

    // foreach (Post post in posts) System.Console.WriteLine($"{post.Title} by {post.Author?.Name} presente em {post.Category?.Name} ");

    var post = context.Posts
    .Include(x => x.Author)
    .Include(x => x.Category)
    .OrderByDescending(x => x.LastUpdateDate)
    .FirstOrDefault();

    System.Console.WriteLine(post?.Title);
    if (post != null)
    {
        post.Author.Name = "Teste";
        context.Posts.Update(post);
        context.SaveChanges();
    }
    System.Console.WriteLine(post?.Author?.Name);
}
Console.WriteLine("Programa finalizado.");