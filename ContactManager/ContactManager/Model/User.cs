using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public class User
    {
        [Key]
        public String userID { get; set; }
        [StringLength(100)]
        public String userName { get; set; }
        [StringLength(100)]
        public String password { get; set; }

    }
}
