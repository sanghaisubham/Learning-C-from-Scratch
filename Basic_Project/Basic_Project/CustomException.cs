using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class CustomException:ApplicationException
    {
        public int ErrorValue;
        public string Description;
        private string origin;
        public override string Source
        {
            get
            {
                return origin;
            }
            set
            {
                origin = value;
            }
        }
        public string ErrorDetails()
        {
            string details = string.Format("Error Value:{0}\n", ErrorValue);
            details += string.Format("Error Message:{0} \n", Description);
            details += string.Format("Error Origin:{0}", Source);
            return details;
        }

    }
}
