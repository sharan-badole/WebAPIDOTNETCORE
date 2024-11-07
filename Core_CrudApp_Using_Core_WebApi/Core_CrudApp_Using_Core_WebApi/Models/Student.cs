using System.ComponentModel.DataAnnotations;

namespace Core_CrudApp_Using_Core_WebApi.Models
{
		public class Student
		{
        public int id { get; set; }
        [Required]
		public string name { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public int standard { get; set; }
		}

}

