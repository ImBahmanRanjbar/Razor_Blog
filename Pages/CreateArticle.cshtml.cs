using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Models;

namespace Razor_Blog.Pages
{
    public class CreateArticleModel : PageModel
    {
        [TempData]
        public string successmessage { get; set; }
        [TempData]
        public string errormessage { get; set; }
        public CreateArticle Command { get; set; }
        private readonly ApplicationDbContext _context;
        public CreateArticleModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }


        public void OnPost(CreateArticle command)
        {
            if (ModelState.IsValid)
            {


                var r = new Article()
                {
                    Title = command.Title,
                    Picture = command.Picture,
                    PictureAlt = command.PictureAlt,
                    PictureTitle = command.PictureTitle,
                    ShortDescription = command.ShortDescription,
                    Body = command.Body
                };
                _context.articles.Add(r);
                _context.SaveChanges();
               successmessage = "مقاله با موفقیت ذخیره شد";
            }
            else
            {
                errormessage = "لطفا مقادیر خواسته شده را وارد نمایید";
            }
        }
    }
}
