// See https://aka.ms/new-console-template for more information
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using BlogDataContext context = new();

Task<List<Post>> post = context
        .Posts
        .ToListAsync();
var resultado = await post;
System.Console.WriteLine(resultado.FirstOrDefault().Title);
// IQueryable<Post> post2 = context.Posts.AsNoTracking();
Console.WriteLine("Programa finalizado.");