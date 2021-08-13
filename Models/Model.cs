using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Articles.Models
{
	 public class Blog
    {
		public int ID { get; set; }  
		public string Title { get; set; }  
		public string Content { get; set; }  
		public int user_id { get; set; }  

		// Time based properties  
		public DateTime CreateTime { get; set; } 

		[DataType(DataType.Upload)]    
		[Display(Name = "Upload File")]    
		[Required(ErrorMessage = "Please choose file to upload.")]    
		public string image { get; set; }    

    }

    
}
