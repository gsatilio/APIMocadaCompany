using APIMocadaCompany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIMocadaCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        List<Company> companies = new List<Company>
            {
               new Company {
                   Cnpj = "95.215.634/0001-78",
                   DtOpen = DateTime.Now ,
                   Name = "Empresa A",
                   NameOpt = "Fant A",
                   Restricted = true,
                   Address = new Address {
                                City = "Araraquara",
                                Complement = "Entre a rua 1 e rua 2",
                                Number = 10,
                                State = "SP",
                                Street = "Rua Central",
                                ZipCode = "14.802-020"
                            }
               },
               new Company {
                   Cnpj = "61.787.912/0001-40",
                   DtOpen = DateTime.Now ,
                   Name = "Empresa B",
                   NameOpt = "Fant B",
                   Restricted = false,
                   Address = new Address {
                                City = "Araraquara",
                                Complement = "",
                                Number = 1253,
                                State = "SP",
                                Street = "Avenida das Laranjas",
                                ZipCode = "14.801-534"
                            }
               },
               new Company {
                   Cnpj = "21.485.353/0001-07",
                   DtOpen = DateTime.Now ,
                   Name = "Empresa C",
                   NameOpt = "Fant C",
                   Restricted = true,
                   Address = new Address {
                                City = "Araraquara",
                                Complement = "",
                                Number = 2,
                                State = "SP",
                                Street = "Rua Central",
                                ZipCode = "14.802-020"
                            }
               },
               new Company {
                   Cnpj = "19.460.488/0001-68",
                   DtOpen = DateTime.Now ,
                   Name = "Empresa D",
                   NameOpt = "Fant D",
                   Restricted = false,
                   Address = new Address {
                                City = "Araraquara",
                                Complement = "",
                                Number = 50,
                                State = "SP",
                                Street = "Rua Central",
                                ZipCode = "14.801-534"
                            }
               }
            };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(companies);
        }

        [HttpGet("{cnpj}")]
        public IActionResult Get(string cnpj)
        {
            cnpj = Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
            var airCraft = companies.FirstOrDefault(x => x.Cnpj == cnpj);
            if (airCraft == null)
            {
                return NotFound();
            }
            return Ok(airCraft);
        }
    }
}
