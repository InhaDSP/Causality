using System;
using System.Collections.Generic;
using CausalityLibrary.Type;
using CausalityLibrary.Util;

namespace CausalityCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new XmlLoader();
            string rootPath = @"C:\REPO\Causality\xml\";
            var roles           = loader.LoadRole       (rootPath + "role.xml");
            var actions         = loader.LoadAction     (rootPath + "action.xml");
            var cusActions      = loader.LoadCustomAction(rootPath + "customaction.xml");
            var perceptrons     = loader.LoadPerceptron (rootPath + "perceptron.xml");
            var causes          = loader.LoadCause      (rootPath + "cause.xml");
            var options         = loader.LoadOption     (rootPath + "option.xml");
            var captions        = loader.LoadCaption    (rootPath + "caption.xml");
            var scenes          = loader.LoadScene      (rootPath + "scene.xml");
            var scenario        = loader.LoadScenario   (rootPath + "scenario.xml");
            var contexts        = loader.LoadContext    (rootPath + "context.xml");

            var sn = new SerialNumber("CAP001");
            var snhs = sn.GetHashCode();
            var hs = captions[1].SerialNumber.GetHashCode();
            var eq = captions[1].SerialNumber.Equals(sn);
            var eq2 = captions[1].SerialNumber != sn;
        }
    }
}
