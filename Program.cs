// See https://aka.ms/new-console-template for more information
// using System.Linq;
using Blog.Data;
using Blog.Models;


using (var context = new BlogDataContext())
{
    var tag = new Tag { Name = "ASPNET", Slug = "aspnetCaio" };
    context.Tags.Add(tag);
    context.SaveChanges();


}
Console.WriteLine("Programa finalizado.");