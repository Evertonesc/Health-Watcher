using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace Hw.Api.Tests.Unit.Helpers
{
    public class JsonFileDataAttribute : DataAttribute
    {
        private readonly string _filePath;
        private readonly string _propertyName;

        public JsonFileDataAttribute(string filePath) : this(filePath, null) { }

        public JsonFileDataAttribute(string filePath, string propertyName = null)
        {
            _filePath = filePath;
            _propertyName = propertyName;
        }
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if (testMethod == null) { throw new ArgumentException(nameof(testMethod)); }

            var path = Path.IsPathRooted(_filePath)
                ? _filePath
                : Path.GetRelativePath(Directory.GetCurrentDirectory(), _filePath);

            if (!File.Exists(path))
                throw new ArgumentException(@$"The specified path was not found, Make sure the Json file is in the build folder and try again: {path}");

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var fileData = File.ReadAllText(_filePath, Encoding.GetEncoding("ISO-8859-1"));

            if (string.IsNullOrEmpty(_propertyName))
                return JsonConvert.DeserializeObject<IEnumerable<object[]>>(fileData);

            var allData = JObject.Parse(fileData);
            var data = allData[_propertyName];
            return data.ToObject<IEnumerable<object[]>>();
        }
    }
}
