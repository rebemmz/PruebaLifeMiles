using wApiMultiPurposeTranslator.Repos;

namespace wApiMultiPurposeTranslator.Services
{
    public class ToBinary : TraslateBase
    {
        public override void Traslate()
        {            
            string result = "";
            for (int i = 0; i < toTraslate.TextToTraslate.Length; i++)
                result += ListBinary.GetBinary(toTraslate.TextToTraslate.Substring(i, 1));

            toTraslate.TextTraslate = result;
        }         
    }
}
