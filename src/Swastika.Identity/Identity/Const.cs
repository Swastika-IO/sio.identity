using System;
using System.Collections.Generic;
using System.Text;

namespace Swastika.Identity
{
    public class Const
    {

        /// <summary>
        /// The constant default connection
        /// </summary>
        public const string CONST_DEFAULT_CONNECTION = "AccountConnection";

        /// <summary>
        /// The constant file appsetting
        /// </summary>
        public const string CONST_FILE_APPSETTING = "appsettings.json";

        public enum ApplicationTypes
        {
            JavaScript = 0,
            NativeConfidential = 1
        };
    }
}
