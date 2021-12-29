using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class DTechnicalPlanPP
    {
        public IEnumerable<ManagementStaffWorkPlan> PlanM = new List<ManagementStaffWorkPlan>();
        public IEnumerable<TechnicalStaffWorkPlan> PlanT = new List<TechnicalStaffWorkPlan>();
    }
}
