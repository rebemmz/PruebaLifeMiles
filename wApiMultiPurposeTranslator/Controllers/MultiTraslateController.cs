using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wApiMultiPurposeTranslator.Models;
using wApiMultiPurposeTranslator.Services;

namespace wApiMultiPurposeTranslator.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MultiTraslateController : ControllerBase
    {
        public IActionResult Post(ToTraslate Traslate)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if (!Traslate.OriginFormatType.Contains("MORSE") && !Traslate.OriginFormatType.Equals("BINARY") && !Traslate.OriginFormatType.Equals("TEXT"))
                return BadRequest("Formato origen no soportado");

            if (!Traslate.TargetFormatType.Equals("MORSE") && !Traslate.TargetFormatType.Equals("BINARY") && !Traslate.TargetFormatType.Equals("TEXT"))
                return BadRequest("Formato destino no soportado");

            if (Traslate.TargetFormatType.Equals(Traslate.OriginFormatType))
                return BadRequest("El formato de salida es igual al de entrada");


            TraslateBase traslate = new TraslateBase();

            if (Traslate.TargetFormatType.Equals("MORSE"))
                traslate = new ToMorse { toTraslate = Traslate };
            else if (Traslate.TargetFormatType.Equals("BINARY"))
                traslate = new ToBinary { toTraslate = Traslate };
            else if(Traslate.OriginFormatType.Equals("MORSE") && Traslate.TargetFormatType.Equals("BINARY"))
                return BadRequest("Lo sentimos proceso en contrucción");
            else if (Traslate.OriginFormatType.Equals("BINARY") && Traslate.TargetFormatType.Equals("MORSE"))
                return BadRequest("Lo sentimos proceso en contrucción");            
            else
                return BadRequest("Lo sentimos proceso en contrucción");

            traslate.Traslate();
            
            return Ok(traslate.toTraslate.TextTraslate);
        }
    }
}
