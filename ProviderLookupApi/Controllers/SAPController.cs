using Microsoft.AspNetCore.Mvc;
using ProviderLookupApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProviderLookupApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SAPController : ControllerBase
    {
        [Route("pm_project/{projectcode?}")]
        [HttpGet]
        public SAPEmployee PM_Project([FromQuery]string projectCode)
        {
            SAPEmployee sapEmployee = default;
            if (projectCode == "P0000001")
            {
                sapEmployee = new SAPEmployee {
                    Role = "PM_Project",
                    SAPCode = 87654321,
                    Name = "Name_PM_Project",
                    EmailId = "PM_Project@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("pm_e4_plus_project/{projectcode?}")]
        [HttpGet]
        public SAPEmployee PM_E4_Plus_Project([FromQuery]string projectCode)
        {
            SAPEmployee sapEmployee = default;
            if (projectCode == "P0000001")
            {
                sapEmployee = new SAPEmployee {
                    Role = "PM_E4_Plus_Project",
                    SAPCode = 87654321,
                    Name = "Name_PM_E4_Plus_Project",
                    EmailId = "PM_E4_Plus_Project@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("rm/{empcode:int?}")]
        [HttpGet]
        public SAPEmployee RM([FromQuery]int empCode)
        {
            SAPEmployee sapEmployee = default;
            if (empCode == 12345678)
            {
                sapEmployee = new SAPEmployee {
                    Role = "RM",
                    SAPCode = 87654321,
                    Name = "Name_RM",
                    EmailId = "PM@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("rm_e4_plus/{empcode:int?}")]
        [HttpGet]
        public SAPEmployee RM_E4_Plus([FromQuery]int empCode)
        {
            SAPEmployee sapEmployee = default;
            if (empCode == 12345678)
            {
                sapEmployee = new SAPEmployee {
                    Role = "RM_E4_Plus",
                    SAPCode = 87654321,
                    Name = "Name_RM_E4_Plus",
                    EmailId = "PM_E4_Plus@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("l3/{empcode:int?}")]
        [HttpGet]
        public SAPEmployee L3(int empCode)
        {
            SAPEmployee sapEmployee = default;
            if (empCode == 12345678)
            {
                sapEmployee = new SAPEmployee {
                    Role = "L3",
                    SAPCode = 87654321,
                    Name = "Name_L3",
                    EmailId = "L3@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("c3_costcenter/{costcenter?}")]
        [HttpGet]
        public SAPEmployee L3_CostCenter([FromQuery]string costCenter)
        {
            SAPEmployee sapEmployee = default;
            if (costCenter == "C0000001")
            {
                sapEmployee = new SAPEmployee {
                    Role = "L3_CostCenter",
                    SAPCode = 87654321,
                    Name = "Name_L3_CostCenter",
                    EmailId = "L3_CostCenter@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("l3_project/{projectcode?}")]
        [HttpGet]
        public SAPEmployee L3_Project([FromQuery]string projectCode)
        {
            SAPEmployee sapEmployee = default;
            if (projectCode == "P0000001")
            {
                sapEmployee = new SAPEmployee {
                    Role = "L3_Project",
                    SAPCode = 87654321,
                    Name = "Name_L3_Project",
                    EmailId = "L3_Project@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("l4/{empcode:int?}")]
        [HttpGet]
        public SAPEmployee L4([FromQuery] int empCode)
        {
            SAPEmployee sapEmployee = default;
            if (empCode == 12345678)
            {
                sapEmployee = new SAPEmployee {
                    Role = "L4",
                    SAPCode = 87654321,
                    Name = "Name_L4",
                    EmailId = "L4@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("l4_costcenter/{empcode:int?}")]
        [HttpGet]
        public SAPEmployee L4_CostCenter([FromQuery]int empCode)
        {
            SAPEmployee sapEmployee = default;
            if (empCode == 12345678)
            {
                sapEmployee = new SAPEmployee {
                    Role = "L4_CostCenter",
                    SAPCode = 87654321,
                    Name = "Name_L4_CostCenter",
                    EmailId = "L4_CostCenter@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("l4_costcenter/{costcenter?}")]
        [HttpGet]
        public SAPEmployee L4_CostCenter([FromQuery]string costCenter)
        {
            SAPEmployee sapEmployee = default;
            if (costCenter == "C0000001")
            {
                sapEmployee = new SAPEmployee {
                    Role = "L4_CostCenter",
                    SAPCode = 87654321,
                    Name = "Name_L4_CostCenter",
                    EmailId = "L4_CostCenter@abc.com"
                };
            }

            return sapEmployee;
        }

        [Route("l4_project/{projectcode?}")]
        [HttpGet]
        public SAPEmployee L4_Project([FromQuery]string projectCode)
        {
            SAPEmployee sapEmployee = default;
            if (projectCode == "P0000001")
            {
                sapEmployee = new SAPEmployee {
                    Role = "L4_Project",
                    SAPCode = 87654321,
                    Name = "Name_L4_Project",
                    EmailId = "L4_Project@abc.com"
                };
            }

            return sapEmployee;
        }
    }
}
