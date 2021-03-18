using System;
using System.Collections.Generic;
using System.Text;

namespace BIMPlatform.Domain.Projects
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LaunchUser { get; set; }
        public DateTime StartDate { get; set; }
        public int CreationUserID { get; set; }
        public DateTime CreationDate { get; set; }
        public string Address { get; set; }
        public decimal ProjectEstimate { get; set; }
        public string ContractType { get; set; }

    }
}
