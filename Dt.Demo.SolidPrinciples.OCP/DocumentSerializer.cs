using DataModel;
using Newtonsoft.Json;

namespace Dt.Demo.SolidPrinciples.OCP
{
    public interface IDocumentSerializer
    {
        string Serilize(Student[] doc);
    }

    public class JsonDocumentSerializer : IDocumentSerializer
    {
        public string Serilize(Student[] doc)
        {
            return JsonConvert.SerializeObject(doc);
        }
    }

    public class CamelCaseJsonSerializer : IDocumentSerializer
    {
        public string Serilize(Student[] doc)
        {
            return new CamelCaseJsonSerializer().Serilize(doc);
        }
    }
}