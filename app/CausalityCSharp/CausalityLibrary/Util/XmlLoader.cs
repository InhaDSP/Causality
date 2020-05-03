using System.Collections.Generic;
using System.Xml;
using CausalityLibrary.Type;

namespace CausalityLibrary.Util
{
    public sealed class XmlLoader
    {
        public List<Role> LoadRole(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var roleNodes = rootNode.ChildNodes;
            var roleList = new List<Role>();
            foreach (XmlNode roleNode in roleNodes)
            {
                string serialNumber = string.Empty;
                string name = string.Empty;
                PositionEnum position = PositionEnum.Extra;
                string description = string.Empty;

                foreach (XmlNode node in roleNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = node.InnerText;
                            break;
                        case "Name":
                            name = node.InnerText;
                            break;
                        case "Position":
                            position = node.InnerText.toPosition();
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                    }
                }
                var role = new Role(serialNumber, description, name, position);

                roleList.Add(role);
            }
            return roleList;
        }

        public List<Action> LoadAction(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var actionNodes = rootNode.ChildNodes;
            var actionList = new List<Action>();
            foreach (XmlNode actionNode in actionNodes)
            {
                string serialNumber = string.Empty;
                string description = string.Empty;
                string value = string.Empty;
                string actorName = string.Empty;
                bool isPerformed = false;

                foreach (XmlNode node in actionNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = node.InnerText;
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "Value":
                            value = node.InnerText;
                            break;
                        case "ActorName":
                            actorName = node.InnerText;
                            break;
                        case "IsPerformed":
                            isPerformed = bool.Parse(node.InnerText);
                            break;
                    }
                }
                if (value.Equals(string.Empty))
                {
                    var action = new Action(
                    serialNumber, description, actorName, isPerformed);
                    actionList.Add(action);
                }
                else
                {
                    var action = new Action(
                    serialNumber, description, actorName, value, isPerformed);
                    actionList.Add(action);
                }
            }
            return actionList;
        }

        public List<Perceptron> LoadPerceptron(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var perceptronNodes = rootNode.ChildNodes;
            var perceptronList = new List<Perceptron>();
            foreach (XmlNode perceptronNode in perceptronNodes)
            {
                string serialNumber = string.Empty;
                string description = string.Empty;
                List<string> inputs = new List<string>();
                List<double> weights = new List<double>();
                double bias = 0;

                foreach (XmlNode node in perceptronNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = node.InnerText;
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "Bias":
                            bias = double.Parse(node.InnerText);
                            break;
                        case "Inputs":
                            foreach (XmlNode input in node.ChildNodes)
                            {
                                inputs.Add(input.InnerText);
                            }
                            break;
                        case "Weights":
                            foreach (XmlNode weight in node.ChildNodes)
                            {
                                weights.Add(double.Parse(weight.InnerText));
                            }
                            break;
                    }
                }
                var perceptron = new Perceptron(
                    serialNumber, description, bias,
                    inputs.ToArray(), weights.ToArray());

                perceptronList.Add(perceptron);
            }
            return perceptronList;
        }

        public List<Cause> LoadCause(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var causeNodes = rootNode.ChildNodes;
            var causeList = new List<Cause>();
            foreach (XmlNode causeNode in causeNodes)
            {
                string serialNumber = string.Empty;
                string description = string.Empty;
                string preceptron = string.Empty;
                List<string> nexts = new List<string>();
                List<double> thresholds = new List<double>();

                foreach (XmlNode node in causeNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = node.InnerText;
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "Preceptron":
                            preceptron = node.InnerText;
                            break;
                        case "Nexts":
                            foreach (XmlNode next in node.ChildNodes)
                            {
                                nexts.Add(next.InnerText);
                            }
                            break;
                        case "Thresholds":
                            foreach (XmlNode threshold in node.ChildNodes)
                            {
                                thresholds.Add(double.Parse(threshold.InnerText));
                            }
                            break;
                    }
                }
                var cause = new Cause(serialNumber, description,
                    preceptron, nexts.ToArray(), thresholds.ToArray());

                causeList.Add(cause);
            }
            return causeList;
        }

        public List<Option> LoadOption(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var optionNodes = rootNode.ChildNodes;
            var optionList = new List<Option>();
            foreach (XmlNode optionNode in optionNodes)
            {
                string serialNumber = string.Empty;
                string description = string.Empty;
                List<string> actions = new List<string>();
                bool isMultiple = false;
                //List<string> chosenActions = new List<string>();

                foreach (XmlNode node in optionNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = node.InnerText;
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "IsMultiple":
                            isMultiple = bool.Parse(node.InnerText);
                            break;
                        case "Actions":
                            foreach (XmlNode action in node.ChildNodes)
                            {
                                actions.Add(action.InnerText);
                            }
                            break;
                        //case "ChosenActions":
                        //    foreach (XmlNode chosenAction in node.ChildNodes)
                        //    {
                        //        chosenActions.Add(chosenAction.InnerText);
                        //    }
                        //    break;
                    }
                }
                var option = new Option(serialNumber, description,
                    actions.ToArray(), isMultiple);

                optionList.Add(option);
            }
            return optionList;
        }

        public List<Caption> LoadCaption(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var captionNodes = rootNode.ChildNodes;
            var captionList = new List<Caption>();
            foreach (XmlNode captionNode in captionNodes)
            {
                string serialNumber = string.Empty;
                string dialogue = string.Empty;
                string cause = string.Empty;
                string speakerName = string.Empty;
                string option = string.Empty;
                string nextCaption = string.Empty;
                bool displayed = false;

                foreach (XmlNode node in captionNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = node.InnerText;
                            break;
                        case "Dialogue":
                            dialogue = node.InnerText;
                            break;
                        case "Cause":
                            cause = node.InnerText;
                            break;
                        case "SpeakerName":
                            speakerName = node.InnerText;
                            break;
                        case "NextCaption":
                            nextCaption = node.InnerText;
                            break;
                        case "Option":
                            option = node.InnerText;
                            break;
                        case "Displayed":
                            displayed = bool.Parse(node.InnerText);
                            break;
                    }
                }
                if (cause.Equals(string.Empty) && option.Equals(string.Empty))
                {// without Cause and Option
                    var caption = new Caption(serialNumber, dialogue, speakerName, nextCaption, displayed);
                    captionList.Add(caption);
                }
                else if (!cause.Equals(string.Empty) && option.Equals(string.Empty))
                {// with Cause, without Option
                    var caption = new Caption(serialNumber, dialogue, speakerName, nextCaption, displayed,
                        cause, true);
                    captionList.Add(caption);
                }
                else if (cause.Equals(string.Empty) && !option.Equals(string.Empty))
                {// with Option, without Cause
                    var caption = new Caption(serialNumber, dialogue, speakerName, nextCaption, displayed,
                        option);
                    captionList.Add(caption);
                }
                else
                {// with Cause and Option
                    var caption = new Caption(serialNumber, dialogue, speakerName, nextCaption, displayed,
                        cause, option);
                    captionList.Add(caption);
                }
            }
            return captionList;
        }

        public List<Scene> LoadScene(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var sceneNodes = rootNode.ChildNodes;
            var sceneList = new List<Scene>();
            foreach (XmlNode sceneNode in sceneNodes)
            {
                string serialNumber = string.Empty;
                string description = string.Empty;
                string caption = string.Empty;
                string cause = string.Empty;
                bool displayed = false;

                foreach (XmlNode node in sceneNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = node.InnerText;
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "Caption":
                            caption = node.InnerText;
                            break;
                        case "Cause":
                            cause = node.InnerText;
                            break;
                        case "Displayed":
                            displayed = bool.Parse(node.InnerText);
                            break;
                    }
                }
                if (cause.Equals(string.Empty))
                {
                    var scene = new Scene(
                        serialNumber, description, caption, displayed);
                    sceneList.Add(scene);
                }
                else
                {
                    var scene = new Scene(
                        serialNumber, description, caption, cause, displayed);
                    sceneList.Add(scene);
                }
            }
            return sceneList;
        }

        public List<Scenario> LoadScenario(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var scenarioNodes = rootNode.ChildNodes;
            var scenarioList = new List<Scenario>();
            foreach (XmlNode scenarioNode in scenarioNodes)
            {
                string serialNumber = string.Empty;
                string description = string.Empty;
                List<string> scenes = new List<string>();
                bool displayed = false;

                foreach (XmlNode node in scenarioNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = node.InnerText;
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "Displayed":
                            displayed = bool.Parse(node.InnerText);
                            break;
                        case "Scenes":
                            foreach (XmlNode scene in node.ChildNodes)
                            {
                                scenes.Add(scene.InnerText);
                            }
                            break;
                    }
                }
                var scenario = new Scenario(serialNumber, description,
                    scenes.ToArray(), displayed);

                scenarioList.Add(scenario);
            }
            return scenarioList;
        }

        public List<Context> LoadContext(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var contextNodes = rootNode.ChildNodes;
            var contextList = new List<Context>();
            foreach (XmlNode contextNode in contextNodes)
            {
                string serialNumber = string.Empty;
                string currentScenario = string.Empty;
                string currentScene = string.Empty;
                string currentCaption = string.Empty;

                foreach (XmlNode node in contextNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = node.InnerText;
                            break;
                        case "CurrentScenario":
                            currentScenario = node.InnerText;
                            break;
                        case "CurrentScene":
                            currentScene = node.InnerText;
                            break;
                        case "CurrentCaption":
                            currentCaption = node.InnerText;
                            break;
                    }
                }
                var context = new Context(serialNumber);
                context.CurrentScenario = currentScenario;
                context.CurrentScene = currentScene;
                context.CurrentCaption = currentCaption;

                contextList.Add(context);
            }
            return contextList;
        }

        private static XmlDocument OpenXml(string filePath)
        {
            var settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            var reader = XmlReader.Create(filePath, settings);
            var doc = new XmlDocument();
            doc.PreserveWhitespace = false;
            try
            {
                doc.Load(reader);
                var rootNode = doc.LastChild;
                return doc;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                //Console.WriteLine("File not found");
                throw ex;
            }
        }
    }
}
