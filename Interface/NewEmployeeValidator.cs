using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmDigital.Interface
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class NewEmployeeValidator : ValidatorExecutor<IEmployee>
    {
        private NewEmployeeValidator() { }

             public static NewEmployeeValidator CreateInstance => new();

        public override string ToString() => "NewEmployer";

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

}




