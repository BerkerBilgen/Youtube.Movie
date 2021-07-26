using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeMovie.Entities.Models;

namespace YoutubeMovie.Entities.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{Username="BerkerB",Password="123",Email="bilgenmehmetberker@gmail.com",Status=1}
            };

            foreach(User u in users)
            {
                context.Users.Add(u);
            }

            var videos = new Video[]
            {
                new Video {Name="Deneme",Description="Deneme Kaydı Video",Status=1}
            };

            foreach (Video v in videos)
            {
                context.Videos.Add(v);
            }

            var categories = new Category[]
            {
                new Category{Name="Korku"}
            };
            foreach(Category c in categories)
            {
                context.Categories.Add(c);
            }

            var sliders = new Slider[]
            {
                new Slider{Text="Deneme",Title="Deneme",Status=1}
            };
            foreach(Slider s in sliders)
            {
                context.Sliders.Add(s);
            }

            var comments = new Comment[]
            {
                new Comment{Text="Merhaba, ilk yorum.",CommentDate=DateTime.Now,}
            };
            foreach (Comment co in comments)
            {
                context.Comments.Add(co);
            }
            context.SaveChanges();

        }
    }
}
