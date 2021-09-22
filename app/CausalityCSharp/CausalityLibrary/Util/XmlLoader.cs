using System;
using System.Collections.Generic;
using System.Xml;
using CausalityLibrary.Type;
using Action = CausalityLibrary.Type.Action;

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
                SerialNumber serialNumber = null;
                string name = string.Empty;
                PositionEnum position = PositionEnum.Extra;
                string description = string.Empty;

                foreach (XmlNode node in roleNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
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
            
            var valid = Validator.InvalidRoles(roleList);
            return roleList;
        }

        public List<Action> LoadAction(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var actionNodes = rootNode.ChildNodes;
            var actionList = new List<Action>();
            foreach (XmlNode actionNode in actionNodes)
            {
                SerialNumber serialNumber = null;
                string description = string.Empty;
                string defaultValue = string.Empty;
                string actorName = string.Empty;

                foreach (XmlNode node in actionNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "DefaultValue":
                            defaultValue = node.InnerText;
                            break;
                        case "ActorName":
                            actorName = node.InnerText;
                            break;
                    }
                }
                if (defaultValue.Equals(string.Empty))
                {
                    var action = new Action(
                    serialNumber, description, actorName);
                    actionList.Add(action);
                }
                else
                {
                    var action = new Action(
                    serialNumber, description, actorName, defaultValue);
                    actionList.Add(action);
                }
            }
            if (Validator.InvalidActions(actionList))
            {
                actionList = null;
            }
            return actionList;
        }

        public List<CustomAction> LoadCustomAction(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var customActionNodes = rootNode.ChildNodes;
            var customActionList = new List<CustomAction>();
            foreach (XmlNode customActionNode in customActionNodes)
            {
                SerialNumber serialNumber = null;
                string description = string.Empty;
                string defaultValue = string.Empty;
                string actorName = string.Empty;

                foreach (XmlNode node in customActionNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "DefaultValue":
                            defaultValue = node.InnerText;
                            break;
                        case "ActorName":
                            actorName = node.InnerText;
                            break;
                    }
                }
                if (defaultValue.Equals(string.Empty))
                {
                    var customAction = new CustomAction(
                    serialNumber, description, actorName);
                    customActionList.Add(customAction);
                }
                else
                {
                    var customAction = new CustomAction(
                    serialNumber, description, actorName, defaultValue);
                    customActionList.Add(customAction);
                }
            }
            if (Validator.InvalidCustomActions(customActionList))
            {
                customActionList = null;
            }
            return customActionList;
        }

        public List<EmotionalAction> LoadEmotionalAction(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var emotionalActionNodes = rootNode.ChildNodes;
            var emotionalActionList = new List<EmotionalAction>();

            foreach (XmlNode emotionalActionNode in emotionalActionNodes)
            {
                SerialNumber serialNumber = null;
                string description = string.Empty;
                string defaultValue = string.Empty;
                string actorName = string.Empty;

                // XML에 꼭 있어야함
                string mediaType = string.Empty; 
                string emotionType = string.Empty; 
                var actions = new List<SerialNumber>(); 
                var emotions = new List<string>();

                foreach (XmlNode node in emotionalActionNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "DefaultValue":
                            defaultValue = node.InnerText;
                            break;
                        case "ActorName":
                            actorName = node.InnerText;
                            break;
                        case "MediaType":
                            mediaType = node.InnerText;
                            break;
                        case "EmotionType":
                            emotionType = node.InnerText;
                            break;
                        case "Actions":
                            foreach (XmlNode action in node.ChildNodes)
                            {
                                actions.Add(new SerialNumber(action.InnerText));
                            }
                            break;
                        case "Emotions":
                            foreach (XmlNode emotion in node.ChildNodes)
                            {
                                emotions.Add(emotion.InnerText);
                            }
                            break;
                    }
                }
                if (defaultValue.Equals(string.Empty))
                {
                    var emotionalAction = new EmotionalAction(
                    serialNumber, description, actorName, mediaType, emotionType,
                    actions.ToArray(), emotions.ToArray());
                    emotionalActionList.Add(emotionalAction);
                }
                else
                {
                    var emotionalAction = new EmotionalAction(
                    serialNumber, description, actorName, mediaType, emotionType,
                    actions.ToArray(), emotions.ToArray(), defaultValue);
                    emotionalActionList.Add(emotionalAction);
                }
            }

            if (Validator.InvalidEmotionalActions(emotionalActionList))
            {
                emotionalActionList = null;
            }
            return emotionalActionList;
        }

        public List<Perceptron> LoadPerceptron(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var perceptronNodes = rootNode.ChildNodes;
            var perceptronList = new List<Perceptron>();
            foreach (XmlNode perceptronNode in perceptronNodes)
            {
                SerialNumber serialNumber = null;
                string description = string.Empty;
                var inputs = new List<SerialNumber>();
                var weights = new List<double>();
                double bias = 0;

                foreach (XmlNode node in perceptronNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
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
                                inputs.Add(new SerialNumber(input.InnerText));
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

            if(Validator.InvalidPerceptrons(perceptronList))
            {
                perceptronList = null;
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
                SerialNumber serialNumber = null;
                string description = string.Empty;
                SerialNumber perceptron = null;
                var nexts = new List<SerialNumber>();
                var thresholds = new List<double>();

                foreach (XmlNode node in causeNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "Perceptron":
                            perceptron = new SerialNumber(node.InnerText);
                            break;
                        case "Nexts":
                            foreach (XmlNode next in node.ChildNodes)
                            {
                                nexts.Add(new SerialNumber(next.InnerText));
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
                    perceptron, nexts.ToArray(), thresholds.ToArray());

                causeList.Add(cause);
            }
            if(Validator.InvalidCauses(causeList))
            {
                causeList = null;
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
                SerialNumber serialNumber = null;
                string description = string.Empty;
                var actions = new List<SerialNumber>();
                bool isMultiple = false;
                //List<string> chosenActions = new List<string>();

                foreach (XmlNode node in optionNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
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
                                actions.Add(new SerialNumber(action.InnerText));
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
            if (Validator.InvalidOptions(optionList))
            {
                optionList = null;
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
                SerialNumber serialNumber = null;
                string dialogue = string.Empty;
                SerialNumber[] dialogueParameter = null;
                SerialNumber cause = null;
                string speakerName = string.Empty;
                SerialNumber option = null;
                SerialNumber nextCaption = null;
                bool displayed = false;

                foreach (XmlNode node in captionNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
                            break;
                        case "Dialogue":
                            dialogue = node.InnerText;
                            break;
                        case "DialogueParameters":
                            List<SerialNumber> dialogueParameterList = new List<SerialNumber>();
                            foreach (XmlNode input in node.ChildNodes)
                            {
                                dialogueParameterList.Add(new SerialNumber(input.InnerText));
                            }
                            dialogueParameter = dialogueParameterList.ToArray();
                            break;
                        case "Cause":
                            cause = new SerialNumber(node.InnerText);
                            break;
                        case "SpeakerName":
                            speakerName = node.InnerText;
                            break;
                        case "NextCaption":
                            nextCaption = new SerialNumber(node.InnerText);
                            break;
                        case "Option":
                            option = new SerialNumber(node.InnerText);
                            break;
                        case "Displayed":
                            displayed = bool.Parse(node.InnerText);
                            break;
                    }
                }

                if ((cause == null) && (option == null))
                {// without Cause and Option
                    var caption = new Caption(serialNumber, dialogue, dialogueParameter,
                        speakerName, nextCaption, displayed);
                    captionList.Add(caption);
                }
                else if ((cause != null) && (option == null))
                {// with Cause, without Option
                    var caption = new Caption(serialNumber, dialogue, dialogueParameter,
                        speakerName, nextCaption, displayed, cause, true);
                    captionList.Add(caption);
                }
                else if ((cause == null) && (option != null))
                {// with Option, without Cause
                    var caption = new Caption(serialNumber, dialogue, dialogueParameter,
                        speakerName, nextCaption, displayed, option);
                    captionList.Add(caption);
                }
                else
                {// with Cause and Option
                    var caption = new Caption(serialNumber, dialogue, dialogueParameter,
                        speakerName, nextCaption, displayed, cause, option);
                    captionList.Add(caption);
                }
            }
            if (Validator.InvalidCaptions(captionList))
            {
                captionList = null;
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
                SerialNumber serialNumber = null;
                string description = string.Empty;
                SerialNumber caption = null;
                SerialNumber cause = null;
                bool displayed = false;

                foreach (XmlNode node in sceneNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "Caption":
                            caption = new SerialNumber(node.InnerText);
                            break;
                        case "Cause":
                            cause = new SerialNumber(node.InnerText);
                            break;
                        case "Displayed":
                            displayed = bool.Parse(node.InnerText);
                            break;
                    }
                }
                if (cause == null)
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
            if (Validator.InvalidScenes(sceneList))
            {
                sceneList = null;
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
                SerialNumber serialNumber = null;
                string description = string.Empty;
                var scenes = new List<SerialNumber>();
                bool displayed = false;

                foreach (XmlNode node in scenarioNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
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
                                scenes.Add(new SerialNumber(scene.InnerText));
                            }
                            break;
                    }
                }
                var scenario = new Scenario(serialNumber, description,
                    scenes.ToArray(), displayed);

                scenarioList.Add(scenario);
            }
            if (Validator.InvalidScenarios(scenarioList))
            {
                scenarioList = null;
            }
            return scenarioList;
        }

        public List<Score> LoadScore(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var scoreNodes = rootNode.ChildNodes;
            var scoreList = new List<Score>();
            foreach (XmlNode scoreNode in scoreNodes)
            {
                SerialNumber serialNumber = null;
                string description = string.Empty;
                var objectives = new List<SerialNumber>();
                ScoreRuleEnum scorerule = ScoreRuleEnum.SimpleAccumulation;

                foreach (XmlNode node in scoreNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "ScoreRule":
                            scorerule = node.InnerText.toScoreRule();
                            break;
                        case "Objectives":
                            foreach (XmlNode objective in node.ChildNodes)
                            {
                                objectives.Add(new SerialNumber(objective.InnerText));
                            }
                            break;
                    }
                }
                var score = new Score(serialNumber, description,
                    scorerule, objectives.ToArray());

                scoreList.Add(score);
            }
            if (Validator.InvalidScores(scoreList))
            {
                scoreList = null;
            }
            return scoreList;
        }

        public List<EmotionScore> LoadEmotionScore(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var emotionScoreNodes = rootNode.ChildNodes;
            var emotionScoreList = new List<EmotionScore>();
            foreach (XmlNode scoreNode in emotionScoreNodes)
            {
                SerialNumber serialNumber = null;
                string description = string.Empty;
                var objectemotions = new List<string>();
                ScoreRuleEnum scorerule = ScoreRuleEnum.SimpleAccumulation;
                string emotiontype = string.Empty;

                foreach (XmlNode node in scoreNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "EmotionType":
                            emotiontype = node.InnerText;
                            break;
                        case "ObjectEmotions":
                            foreach (XmlNode objectemotion in node.ChildNodes)
                            {
                                objectemotions.Add(objectemotion.InnerText);
                            }
                            break;
                        case "ScoreRule":
                            scorerule = node.InnerText.toScoreRule();
                            break;
                    }
                }
                var score = new EmotionScore(serialNumber, description,
                    scorerule, emotiontype, objectemotions.ToArray());

                emotionScoreList.Add(score);
            }
            if (Validator.InvalidEmotionScores(emotionScoreList))
            {
                emotionScoreList = null;
            }
            return emotionScoreList;
        }

        public List<ScoreFeedback> LoadScoreFeedback(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var scoreFeedbackNodes = rootNode.ChildNodes;
            var scoreFeedbackList = new List<ScoreFeedback>();
            foreach (XmlNode scoreFeedbackNode in scoreFeedbackNodes)
            {
                SerialNumber serialNumber = null;
                string description = string.Empty;
                ScoreFeedbackEnum feedbackrule = ScoreFeedbackEnum.QuantizedClassification;
                SerialNumber score = null;
                var scoresteps = new List<double>();
                var scoremessages = new List<string>();

                foreach (XmlNode node in scoreFeedbackNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(node.InnerText);
                            break;
                        case "Description":
                            description = node.InnerText;
                            break;
                        case "FeedbackRule":
                            feedbackrule = node.InnerText.toScoreFeedback();
                            break;
                        case "Score":
                            score = new SerialNumber(node.InnerText);
                            break;
                        case "ScoreSteps":
                            foreach (XmlNode scorestep in node.ChildNodes)
                            {
                                scoresteps.Add(double.Parse(scorestep.InnerText));
                            }
                            break;
                        case "ScoreMessages":
                            foreach (XmlNode scoremessage in node.ChildNodes)
                            {
                                scoremessages.Add(scoremessage.InnerText);
                            }
                            break;
                    }
                }
                var scorefeedback = new ScoreFeedback(serialNumber, description,
                    feedbackrule, score, scoresteps.ToArray(), scoremessages.ToArray());

                scoreFeedbackList.Add(scorefeedback);
            }
            if (Validator.InvalidScoreFeedbacks(scoreFeedbackList))
            {
                scoreFeedbackList = null;
            }
            return scoreFeedbackList;
        }

        public List<Context> LoadContext(string filePath)
        {
            var rootNode = OpenXml(filePath).LastChild;
            var contextNodes = rootNode.ChildNodes;
            var contextList = new List<Context>();
            foreach (XmlNode contextNode in contextNodes)
            {
                Guid guid = Guid.Empty;
                SerialNumber currentScenario = null;
                SerialNumber currentScene = null;
                SerialNumber currentCaption = null;

                foreach (XmlNode node in contextNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "GUID":
                            guid = Guid.Parse(node.InnerText);
                            break;
                        case "CurrentScenario":
                            currentScenario = new SerialNumber(node.InnerText);
                            break;
                        case "CurrentScene":
                            currentScene = new SerialNumber(node.InnerText);
                            break;
                        case "CurrentCaption":
                            currentCaption = new SerialNumber(node.InnerText);
                            break;
                    }
                }
                var context = new Context(guid);
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
