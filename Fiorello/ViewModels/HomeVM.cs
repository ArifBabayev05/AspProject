using System;
using System.Collections.Generic;
using DAL.Models;

namespace Fiorello.ViewModels
{
	public class HomeVM
	{
		public List<Product> Products { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Expert> Experts{ get; set; }


    }
}

