using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace TestAlex.Viewmodels
{
    public class GameViewModel
    {
        public int Id { get; set; }

        [Browsable(false)]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Name { get; set; }

        [Browsable(false)]
        public string Description { get; set; }

        [Browsable(false)]
        public Image Logo { get; set; }
    }
}
