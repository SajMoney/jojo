using FileUpload.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HromadaGalerii.Models
{
    public class StoredFile
    {
        [Key]
        public Guid Id { get; set; } 
        [ForeignKey("UploaderId")]
        public User Uploader { get; set; } 
        [Required]
        public string UploaderId { get; set; }
        [Required]
        public DateTime UploadedAt { get; set; } 
        [Required]
        public string OriginalName { get; set; } 
        [Required]
        public string ContentType { get; set; } 
        public bool IsDefault { get; set; } 
        public bool IsPublic { get; set; }
        public DateTime ExifDateTaken { get; set; } 
        public ThumbnailBlob Thumbnail { get; set; }
        public Guid? ThumbnailId { get; set; }
        public int? GalleryId { get; set; }
        
        public Gallery Gallery { get; set; }
    }
}
