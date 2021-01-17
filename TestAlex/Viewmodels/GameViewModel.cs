using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TestAlex.Viewmodels
{
    public class GameViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Image Logo { get; set; }
    }
}
