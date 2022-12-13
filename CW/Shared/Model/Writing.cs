using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.Shared.Model {

    public class Writing {

        [Key]
        public int Id { get; set; }

        [ForeignKey("FandomId")]
        public string Characters { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Text { get; set; }
        public string Genres { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

    }

}
