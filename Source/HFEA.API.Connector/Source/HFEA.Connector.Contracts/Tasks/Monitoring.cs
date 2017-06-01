using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.Tasks
{
    public class Monitoring
    {
        public int InspectionRating { get; set; }

        public List<TaskItem> Tasks { get; set; }
    }
}
