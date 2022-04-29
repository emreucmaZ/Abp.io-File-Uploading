using System.Threading.Tasks;
using File.Uploading.FileStoraging;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace File.Uploading.Controllers;

public class FileController : AbpController
{
 private readonly IFileAppService _fileAppService;

 public FileController(IFileAppService fileAppService)
 {
     _fileAppService = fileAppService;
 }

 [HttpGet]
 [Route("download/{fileName}")]
 public async Task<IActionResult> DownloadAsync(string fileName)
 {
     var fileDto = await _fileAppService.GetBlobAsync(new GetBlobRequestDto {Name = fileName});

     return File(fileDto.Content, "application/octec-stream", fileDto.Name);
 }
}