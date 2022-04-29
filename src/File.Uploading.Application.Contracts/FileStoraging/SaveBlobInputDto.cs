using System.ComponentModel.DataAnnotations;

namespace File.Uploading.FileStoraging;

public class SaveBlobInputDto
{
    public byte[] Content { get; set; }
    [Required]
    public string Name { get; set; }
}