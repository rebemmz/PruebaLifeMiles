using wApiMultiPurposeTranslator.Repos;

namespace wApiMultiPurposeTranslator.Services
{
    public class ToMorse : TraslateBase
    {
        public override void Traslate()
        {
            string result = "";
            toTraslate.TextToTraslate = toTraslate.TextToTraslate.ToUpper(); 
            for (int i = 0; i < toTraslate.TextToTraslate.Length; i++)
                result += ListMorse.GetMorse(toTraslate.TextToTraslate.Substring(i, 1));

            toTraslate.TextTraslate = result;
        }
    }
}
