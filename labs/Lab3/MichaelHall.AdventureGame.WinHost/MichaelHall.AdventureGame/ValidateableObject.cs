using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelHall.AdventureGame
{
    public class ValidateableObject
    {
        public bool IsValid
        {
            get { return TryValidate(out var _); }
        }

        public virtual bool TryValidate( out string message)
        {
            message = "";
            return true;
        }

        public string Validate()
        {
            if(!TryValidate(out var message))
            {
                return message;
            }
            return "";
        }

    }
}
