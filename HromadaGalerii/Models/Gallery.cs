﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HromadaGalerii.Models
{
    public class Gallery
    {
       

        public int GalleryId { get; set; }
        public string GalleryName { get; set; } = "Your First Gallery";

        public string GalleryBackgroundColor { get; set; } = "#FFFFFF";
        public bool IsPublic { get; set; }
        public string UserId { get; set; }
        [Required]
        public User User { get; set; }

        public ICollection<StoredFile> Images { get; set; } = new List<StoredFile>();
        
    }
}
