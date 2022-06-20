using System;
using DAL.Base;

namespace DAL.Models
{
	public class Slider :BaseEntity
	{
        public int? ImageId { get; set; }
        public Image Image { get; set; }
    }
}

