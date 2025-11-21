using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Geder { get; set; }
        public OperationResult ValidationInputs()
        {
            var valid =new OperationResult();

            if (FirstName.Length < 3)
            {
                valid.Success = false;
                valid.Message = "اسم نمیتواند کمتر از3 کاراکتر باشد";
            }
            else
            if (NationalCode.Length < 10)
            {
                valid.Success = false;
                valid.Message = "کد ملی نمیتواند کمتر از 10 رقم باشد است";
            }
            else
            {
                valid.Success = true;
            }
            return valid;
        }
        
    }
}
