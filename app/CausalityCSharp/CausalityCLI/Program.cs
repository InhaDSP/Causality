using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CausalityLibrary.Type;
using CausalityLibrary.Util;

namespace CausalityCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new XmlLoader();
            string rootPath = @"D:\REPO\Causality\xml\";
            var roles = loader.LoadRole(rootPath + "role.xml");
            var actions = loader.LoadAction(rootPath + "action.xml");
            var cusActions = loader.LoadCustomAction(rootPath + "customaction.xml");
            var emoActions = loader.LoadEmotionalAction(rootPath + "emotionalaction.xml");
            var perceptrons = loader.LoadPerceptron(rootPath + "perceptron.xml");
            var causes = loader.LoadCause(rootPath + "cause.xml");
            var options = loader.LoadOption(rootPath + "option.xml");
            var captions = loader.LoadCaption(rootPath + "caption.xml");
            var scenes = loader.LoadScene(rootPath + "scene.xml");
            var scenario = loader.LoadScenario(rootPath + "scenario.xml");
            var contexts = loader.LoadContext(rootPath + "context.xml");

            var scores = loader.LoadScore(rootPath + "score.xml");
            var emotionscores = loader.LoadEmotionScore(rootPath + "emotionscore.xml");
            var scorefeedbacks = loader.LoadScoreFeedback(rootPath + "scorefeedback.xml");

            var a = 1;
            //TestSerialNumber(captions);
            //TestSerialize(actions);
        }

        private static void TestSerialize(List<CausalityLibrary.Type.Action> actions)
        {
            var stream = new FileStream("data.bin", FileMode.Create);
            var formatter = new BinaryFormatter();

            formatter.Serialize(stream, actions);
            stream.Close();

            stream = new FileStream("data.bin", FileMode.Open);
            var actions2 = (List<CausalityLibrary.Type.Action>)formatter.Deserialize(stream);
            stream.Close();
        }

        private static void TestSerialNumber(List<Caption> captions)
        {
            var sn = new SerialNumber("CAP001");
            var snhs = sn.GetHashCode();
            var hs = captions[1].SerialNumber.GetHashCode();
            var eq = captions[1].SerialNumber.Equals(sn);
            var eq2 = captions[1].SerialNumber != sn;
        }
    }
}
