// See https://aka.ms/new-console-template for more information
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using BlogDataContext context = new();

Post? post = context
        .Posts
        .FirstOrDefault(x => x.Id == 1);

IQueryable<Post> post2 = context.Posts.AsNoTracking();

Console.WriteLine("Programa finalizado.");