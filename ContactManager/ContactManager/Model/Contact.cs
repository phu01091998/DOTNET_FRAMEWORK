using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public class Contact
    {
        [Key]
        public String contactID { get; set; }
        [StringLength(100)]
        public String contactName { get; set; }
        [StringLength(100)]
        public String phoneNumber { get; set; }
        [StringLength(100)]
        public String email { get; set; }
        
        public String userID { get; set; }

    


    }
}
