using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestAlex.DataAccess.Entities
{
    public class Game
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Logo { get; set; }
    }
}
