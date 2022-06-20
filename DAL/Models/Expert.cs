using System;
using DAL.Base;

namespace DAL.Models
{
	public class Expert  : BaseEntity
	{
        public string Fullname { get; set; }
        public string Position { get; set; }
        public int? ImageId { get; set; }
        public Image Image { get; set; }
    }
}

