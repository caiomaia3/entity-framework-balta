// See https://aka.ms/new-console-template for more information
using Blog.Data;
using Blog.Models;


using (var context = new BlogDataContext())
{
    // var tag = new Tag { Name = "ASPNET", Slug = "aspnetCaio" };
    // context.Tags.Add(tag);
    // context.SaveChanges();

    var tag = context.Tags.FirstOrDefault<Tag>(x => x.Id == 3);
    tag.Name = ".NET";
    tag.Slug = "dotnet";

    context.Update(tag);
    context.SaveChanges();
}
Console.WriteLine("Programa finalizado.");