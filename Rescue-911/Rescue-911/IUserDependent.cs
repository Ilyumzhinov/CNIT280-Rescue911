using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_911
{
    interface IUserDependent
    {
        // Identify a special type of Forms and Views which require User to be set properly.
        void SendUser(Person xUser);
    }
}
