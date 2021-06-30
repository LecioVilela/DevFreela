using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException() : base("Project is already in Started status") 
        {

        }
    }
}
