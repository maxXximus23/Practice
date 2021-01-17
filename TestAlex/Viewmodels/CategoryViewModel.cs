using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TestAlex.Viewmodels
{
    public class CategoryViewModel
    {
        public string Name { get; set; }

        [DisplayName("Total Games")]
        public int Count { get; set; }

        [Browsable(false)]
        public int Id { get; set; }
    }
}
