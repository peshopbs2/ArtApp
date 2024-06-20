using ArtApp.Services.DTOs.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtApp.Services.DTOs
{
    public class ArtistDTO : BaseDTO
    {
        [MinLength(3)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [MinLength(3)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [MinLength(3)]
        public string Bio { get; set; }
    }
}
