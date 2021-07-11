using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WindowsFormsApp1.Impl {
    class JsonController {
        public string ExceptionMessage { get; set; }
        public string _JsonFile { get; set; }

        public JsonController(string jsonFile) {
            _JsonFile = jsonFile;

        }

        public void SerializeToJson(University MasterData) {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(MasterData);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }


        public University DeserializeFromJson() {
            try {

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

                if (File.Exists(path)) {
                    string data = File.ReadAllText(path);

                    University MasterData = serializer.Deserialize<University>(data);
                    return MasterData;
                }
            }
            catch (Exception ex) {

                ExceptionMessage = ex.Message;
            }
            return null;
        }
    }
}
