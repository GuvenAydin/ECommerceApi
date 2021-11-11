using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.Controllers.Base.v1
{
    [Route("v{version:apiVersion}/[controller]")]
    public class Basev1ApiController : BaseApiController
    {

    }
}