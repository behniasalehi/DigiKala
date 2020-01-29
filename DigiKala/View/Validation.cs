using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DigiKala.View
{
  public  class Validation
    {
        
        #region [- ctor -]
        public Validation()
        {

        }
        #endregion
        #region [- CategoryNameValidation(string String) -]
        public bool CategoryNameValidation(string String)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]{1,50}$");
            Match match = regex.Match(String.ToLower());
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion
        #region [- CategorydescriptionsValidation(string String) -]
        public bool CategorydescriptionsValidation(string String)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]{0,100}$");
            Match match = regex.Match(String.ToLower());
            if (!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion
    }
}
