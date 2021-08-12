using System;
using System.Collections.Generic;
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

    }

    
}
