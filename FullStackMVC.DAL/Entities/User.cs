using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackMVC.DAL.Entities
{
    public class User
    {
        /// <summary>
        /// Provides a regex for date in format dd.mm.yyyy
        /// </summary>
        private const string V = "^(0?[1-9]|1[0-2])[\\.](0?[1-9]|[12]\\d|3[01])[\\.](19|20)\\d{2}$";

        [Required]
        public int UserId { get; set; }
        [Required]
        [RegularExpression(V)]
        public string DateRegistration { get; set; }
        [Required]
        [RegularExpression(V)]
        public string DateLastOnline { get; set; }
    }
}
