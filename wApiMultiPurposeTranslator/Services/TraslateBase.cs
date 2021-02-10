using wApiMultiPurposeTranslator.Models;

namespace wApiMultiPurposeTranslator.Services
{
    public class TraslateBase
    {
        public ToTraslate toTraslate { get; set; }
        public virtual void Traslate() { }
    }
}
