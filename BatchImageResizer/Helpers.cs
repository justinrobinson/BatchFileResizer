using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BatchImageResizer
{
    public static class Helpers
    {
        public static FileVersionInfo GetProductAssemblyInformation()
        {
            // get assembly information
            var assembly = Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi;

            /* examples */
            var productName = fvi.ProductName;
            var fileDescription = fvi.FileDescription;
            var companyName = fvi.CompanyName;
            var version = fvi.FileVersion;  // Application.ProductVersion

        }
    }
}
