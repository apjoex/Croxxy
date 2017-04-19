using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croxxy.models
{
    public class Croxx : RealmObject
    {
        public string Name{get; set;}
    
        public string Email { get; set; }

        public string Bio { get; set; }



        //
        public Croxx() {
            this.Name = "";
            this.Email = "";
            this.Bio = "";
        }


    }
    
}
