using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using File.Uploading.FileStoraging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace File.Uploading.Web.Pages;

public class IndexModel : AbpPageModel
{
    [BindProperty] 
    public UploadFileDto UploadFile { get; set; }

    private readonly IFileAppService _fileAppService;

    public bool Uploaded { get; set; } = false;

    public IndexModel(IFileAppService fileAppService)
    {
        _fileAppService = fileAppService;
    }

    public void OnGet()
    {
        
    }

    public async Task<IActionResult> OnPostAsync()
    {
        using (var memoryStream = new MemoryStream())
        {
            await UploadFile.File.CopyToAsync(memoryStream);

            await _fileAppService.SaveBlobAsync(
                new SaveBlobInputDto
                {
                    Name = UploadFile.Name,
                    Content = memoryStream.ToArray()
                });
        }

        return Page();
    }

    public class UploadFileDto
    {
        [Required]
        [Display(Name="File")]
        public IFormFile File { get; set; }

        [Required]
        [Display(Name="Filename")]
        public string Name { get; set; }
    }
}
