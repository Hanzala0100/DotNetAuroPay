using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDeviceControl
{
    internal interface IStatusReportable
    {
        void ReportStatus(string message);
    }
}
