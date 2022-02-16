﻿ using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		[Required]
		public string AuthorName { get; set; }
		[Required]
		public Genre Genre { get; set; }
		public byte GenreId { get; set; }
		public DateTime DateAdded { get; set; }
		[Required(ErrorMessage = "Release Date is required.")]
		public DateTime ReleaseDate { get; set; }
		[Required]
		public int NumberInStock { get; set; }
		[Required]
		public int NumberAvailable { get; set; }

	}
      
}
