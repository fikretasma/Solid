using Newtonsoft.Json;

namespace Dt.Demo.SingleResponsibility
{
    public class DocumentSerializer
    {
        public object Serilize(object doc)
        {
            return JsonConvert.SerializeObject(doc);
        }
    }
}