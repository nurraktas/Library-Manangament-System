using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__project_1_Library_manangament_system_
{
    public interface Iperson
    {
        string PersonID { get;set;}   // unique id for person
        string Name { get; set; } 

        void DisplayInfo();


    }
}
