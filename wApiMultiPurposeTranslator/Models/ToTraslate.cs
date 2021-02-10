using System.ComponentModel.DataAnnotations;

namespace wApiMultiPurposeTranslator.Models
{
    public class ToTraslate
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string TextToTraslate { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string OriginFormatType { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string TargetFormatType { get; set; }

        public string TextTraslate { get; set; }
    }
}
