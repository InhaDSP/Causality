package com.inha.dsp.causality.util;

import com.inha.dsp.causality.type.*;
import org.w3c.dom.Document;
import org.w3c.dom.Node;
import org.xml.sax.SAXException;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.UUID;

public class XmlLoader {
    public ArrayList<Role> LoadRole(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadRole(xmlDocument);
    }

    public ArrayList<Role> LoadRole(Document xmlDocument)
    {
        var roleList = new ArrayList<Role>();
        var rootNode = xmlDocument.getLastChild();
        var roleNodes = rootNode.getChildNodes();
        for (int i = 0; i < roleNodes.getLength(); i++) {
            SerialNumber serialNumber = null;
            String name = "";
            PositionEnum position = PositionEnum.Extra;
            String description = "";

            var roleNode = roleNodes.item(i);
            if(!roleNode.getNodeName().equals("Role")) {
                continue;
            }
            var propertyNodes = roleNode.getChildNodes();
            for (int j = 0; j < propertyNodes.getLength(); j++) {
                var propertyNode = propertyNodes.item(j);
                switch (propertyNode.getNodeName())
                {
                    case "SerialNumber":
                        serialNumber = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Name":
                        name = propertyNode.getTextContent();
                        break;
                    case "Position":
                        position = StringExtension.toPosition(propertyNode.getTextContent());
                        break;
                    case "Description":
                        description = propertyNode.getTextContent();
                        break;
                }
            }

            var role = new Role(serialNumber, description, name, position);
            roleList.add(role);
        }
        return roleList;
    }

    public ArrayList<Action> LoadAction(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadAction(xmlDocument);
    }
    public ArrayList<Action> LoadAction(Document xmlDocument)
    {
        var actionList = new ArrayList<Action>();
        var rootNode = xmlDocument.getLastChild();
        var actionNodes = rootNode.getChildNodes();
        for (int i = 0; i < actionNodes.getLength(); i++) {
            SerialNumber serialNumber = null;
            String actorName = "";
            String description = "";
            String defaultvalue = "";

            var actionNode = actionNodes.item(i);
            if(!actionNode.getNodeName().equals("Action")) {
                continue;
            }
            var propertyNodes = actionNode.getChildNodes();
            for (int j = 0; j < propertyNodes.getLength(); j++) {
                var propertyNode = propertyNodes.item(j);
                switch (propertyNode.getNodeName())
                {
                    case "SerialNumber":
                        serialNumber = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Description":
                        description = propertyNode.getTextContent();
                        break;
                    case "DefaultValue":
                        defaultvalue = propertyNode.getTextContent();
                        break;
                    case "ActorName":
                        actorName = propertyNode.getTextContent();
                        break;
                }
            }
            var action = new Action(serialNumber, description, actorName, defaultvalue);
            actionList.add(action);
        }
        return actionList;
    }

    public ArrayList<CustomAction> LoadCustomAction(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadCustomAction(xmlDocument);
    }
    public ArrayList<CustomAction> LoadCustomAction(Document xmlDocument)
    {
        var customActionList = new ArrayList<CustomAction>();
        var rootNode = xmlDocument.getLastChild();
        var customActionNodes = rootNode.getChildNodes();
        for (int i = 0; i < customActionNodes.getLength(); i++) {
            SerialNumber serialNumber = null;
            String actorName = "";
            String description = "";
            String defaultvalue = "";

            var customActionNode = customActionNodes.item(i);
            if(!customActionNode.getNodeName().equals("CustomAction")) {
                continue;
            }
            var propertyNodes = customActionNode.getChildNodes();
            for (int j = 0; j < propertyNodes.getLength(); j++) {
                var propertyNode = propertyNodes.item(j);
                switch (propertyNode.getNodeName())
                {
                    case "SerialNumber":
                        serialNumber = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Description":
                        description = propertyNode.getTextContent();
                        break;
                    case "DefaultValue":
                        defaultvalue = propertyNode.getTextContent();
                        break;
                    case "ActorName":
                        actorName = propertyNode.getTextContent();
                        break;
                }
            }
            var customAction = new CustomAction(serialNumber, description, actorName, defaultvalue);
            customActionList.add(customAction);
        }

        return customActionList;
    }

    public ArrayList<Perceptron> LoadPerceptron(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadPerceptron(xmlDocument);
    }
    public ArrayList<Perceptron> LoadPerceptron(Document xmlDocument)
    {
        var perceptronList = new ArrayList<Perceptron>();
        var rootNode = xmlDocument.getLastChild();
        var perceptronNodes = rootNode.getChildNodes();
        for (int i = 0; i < perceptronNodes.getLength(); i++) {
            SerialNumber serialNumber = null;
            String description = "";
            var inputs = new ArrayList<SerialNumber>();
            var weights = new ArrayList<Double>();
            double bias = 0;

            var perceptronNode = perceptronNodes.item(i);
            if(!perceptronNode.getNodeName().equals("Perceptron")) {
                continue;
            }
            var propertyNodes = perceptronNode.getChildNodes();
            for (int j = 0; j < propertyNodes.getLength(); j++) {
                var propertyNode = propertyNodes.item(j);
                switch (propertyNode.getNodeName())
                {
                    case "SerialNumber":
                        serialNumber = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Description":
                        description = propertyNode.getTextContent();
                        break;
                    case "Bias":
                        bias = Double.parseDouble(propertyNode.getTextContent());
                        break;
                    case "Inputs":
                        var inputNodes = propertyNode.getChildNodes();
                        for (int k = 0; k < inputNodes.getLength(); k++) {
                            if(!inputNodes.item(k).getNodeName().equals("Input")) {
                                continue;
                            }
                            inputs.add(new SerialNumber(inputNodes.item(k).getTextContent()));
                        }
                        break;
                    case "Weights":
                        var weightNodes = propertyNode.getChildNodes();
                        for (int k = 0; k < weightNodes.getLength(); k++) {
                            if(!weightNodes.item(k).getNodeName().equals("Weight")) {
                                continue;
                            }
                            weights.add(Double.parseDouble(weightNodes.item(k).getTextContent()));
                        }
                        break;
                }
            }

            SerialNumber[] arrInputs = new SerialNumber[inputs.size()];
            arrInputs = inputs.toArray(arrInputs);
            double[] arrWeights = new double[weights.size()];
            for (int j = 0; j < weights.size(); j++) {
                arrWeights[j] = weights.get(j);
            }
            var perceptron = new Perceptron(
                    serialNumber, description, bias,
                    arrInputs, arrWeights);
            perceptronList.add(perceptron);
        }
        return perceptronList;
    }

    public ArrayList<Cause> LoadCause(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadCause(xmlDocument);
    }
    public ArrayList<Cause> LoadCause(Document xmlDocument)
    {
        var causeList = new ArrayList<Cause>();
        var rootNode = xmlDocument.getLastChild();
        var causeNodes = rootNode.getChildNodes();
        for (int i = 0; i < causeNodes.getLength(); i++) {
            SerialNumber serialNumber = null;
            String description = "";
            SerialNumber perceptron = null;
            var nexts = new ArrayList<SerialNumber>();
            var thresholds = new ArrayList<Double>();

            var causeNode = causeNodes.item(i);
            if(!causeNode.getNodeName().equals("Cause")) {
                continue;
            }
            var propertyNodes = causeNode.getChildNodes();
            for (int j = 0; j < propertyNodes.getLength(); j++) {
                var propertyNode = propertyNodes.item(j);
                switch (propertyNode.getNodeName())
                {
                    case "SerialNumber":
                        serialNumber = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Description":
                        description = propertyNode.getTextContent();
                        break;
                    case "Perceptron":
                        perceptron = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Nexts":
                        var inputNodes = propertyNode.getChildNodes();
                        for (int k = 0; k < inputNodes.getLength(); k++) {
                            if(!inputNodes.item(k).getNodeName().equals("Next")) {
                                continue;
                            }
                            nexts.add(new SerialNumber(inputNodes.item(k).getTextContent()));
                        }
                        break;
                    case "Thresholds":
                        var weightNodes = propertyNode.getChildNodes();
                        for (int k = 0; k < weightNodes.getLength(); k++) {
                            if(!weightNodes.item(k).getNodeName().equals("Threshold")) {
                                continue;
                            }
                            thresholds.add(Double.parseDouble(weightNodes.item(k).getTextContent()));
                        }
                        break;
                }
            }

            SerialNumber[] arrNexts = new SerialNumber[nexts.size()];
            arrNexts = nexts.toArray(arrNexts);
            double[] arrThresholds = new double[thresholds.size()];
            for (int j = 0; j < thresholds.size(); j++) {
                arrThresholds[j] = thresholds.get(j);
            }
            var cause = new Cause(
                    serialNumber, description, perceptron,
                    arrNexts, arrThresholds);
            causeList.add(cause);
        }
        return causeList;
    }

    public ArrayList<Option> LoadOption(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadOption(xmlDocument);
    }
    public ArrayList<Option> LoadOption(Document xmlDocument)
    {
        var optionList = new ArrayList<Option>();
        var rootNode = xmlDocument.getLastChild();
        var optionNodes = rootNode.getChildNodes();
        for (int i = 0; i < optionNodes.getLength(); i++) {
            SerialNumber serialNumber = null;
            String description = "";
            var actions = new ArrayList<SerialNumber>();
            boolean isMultiple = false;

            var optionNode = optionNodes.item(i);
            if(!optionNode.getNodeName().equals("Option")) {
                continue;
            }
            var propertyNodes = optionNode.getChildNodes();
            for (int j = 0; j < propertyNodes.getLength(); j++) {
                var propertyNode = propertyNodes.item(j);
                switch (propertyNode.getNodeName())
                {
                    case "SerialNumber":
                        serialNumber = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Description":
                        description = propertyNode.getTextContent();
                        break;
                    case "IsMultiple":
                        isMultiple = Boolean.parseBoolean(propertyNode.getTextContent());
                        break;
                    case "Actions":
                        var actionNodes = propertyNode.getChildNodes();
                        for (int k = 0; k < actionNodes.getLength(); k++) {
                            if(!actionNodes.item(k).getNodeName().equals("Action")) {
                                continue;
                            }
                            actions.add(new SerialNumber(actionNodes.item(k).getTextContent()));
                        }
                        break;
                }
            }

            SerialNumber[] arrActions = new SerialNumber[actions.size()];
            arrActions = actions.toArray(arrActions);
            var option = new Option(serialNumber, description, arrActions, isMultiple);
            optionList.add(option);
        }
        return optionList;
    }

    public ArrayList<Scene> LoadScene(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadScene(xmlDocument);
    }
    public ArrayList<Scene> LoadScene(Document xmlDocument)
    {
        var sceneList = new ArrayList<Scene>();
        var rootNode = xmlDocument.getLastChild();
        var sceneNodes = rootNode.getChildNodes();
        for (int i = 0; i < sceneNodes.getLength(); i++) {
            SerialNumber serialNumber = null;
            String description = "";
            SerialNumber caption = null;
            SerialNumber cause = null;
            boolean displayed = false;


            var sceneNode = sceneNodes.item(i);
            if(!sceneNode.getNodeName().equals("Scene")) {
                continue;
            }
            var propertyNodes = sceneNode.getChildNodes();
            for (int j = 0; j < propertyNodes.getLength(); j++) {
                var propertyNode = propertyNodes.item(j);
                switch (propertyNode.getNodeName()) {
                    case "SerialNumber":
                        serialNumber = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Description":
                        description = propertyNode.getTextContent();
                        break;
                    case "Caption":
                        caption = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Cause":
                        cause = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Displayed":
                        displayed = Boolean.parseBoolean(propertyNode.getTextContent());
                        break;
                }
            }

            if(cause == null) {
                var scene = new Scene(
                        serialNumber, description, caption, displayed);
                sceneList.add(scene);
            } else {
                var scene = new Scene(
                        serialNumber, description, caption, cause, displayed);
                sceneList.add(scene);
            }
        }
        return sceneList;
    }

    public ArrayList<Scenario> LoadScenario(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadScenario(xmlDocument);
    }
    public ArrayList<Scenario> LoadScenario(Document xmlDocument)
    {
        var scenarioList = new ArrayList<Scenario>();
            var rootNode = xmlDocument.getLastChild();
            var scenarioNodes = rootNode.getChildNodes();
            for (int i = 0; i < scenarioNodes.getLength(); i++) {
                SerialNumber serialNumber = null;
                String description = "";
                var scenes = new ArrayList<SerialNumber>();
                boolean displayed = false;

                var scenarioNode = scenarioNodes.item(i);
                if(!scenarioNode.getNodeName().equals("Scenario")) {
                    continue;
                }
                var propertyNodes = scenarioNode.getChildNodes();
                for (int j = 0; j < propertyNodes.getLength(); j++) {
                    var propertyNode = propertyNodes.item(j);
                    switch (propertyNode.getNodeName()) {
                        case "SerialNumber":
                            serialNumber = new SerialNumber(propertyNode.getTextContent());
                            break;
                        case "Description":
                            description = propertyNode.getTextContent();
                            break;
                        case "Displayed":
                            displayed = Boolean.parseBoolean(propertyNode.getTextContent());
                            break;
                        case "Scenes":
                            var sceneNodes = propertyNode.getChildNodes();
                            for (int k = 0; k < sceneNodes.getLength(); k++) {
                                if(!sceneNodes.item(k).getNodeName().equals("Scene")) {
                                    continue;
                                }
                                scenes.add(new SerialNumber(sceneNodes.item(k).getTextContent()));
                            }
                            break;
                    }
                }

                SerialNumber[] arrScenes = new SerialNumber[scenes.size()];
                arrScenes = scenes.toArray(arrScenes);
                var scenario = new Scenario(
                        serialNumber, description, arrScenes, displayed);
                scenarioList.add(scenario);
            }
        return scenarioList;
    }

    public ArrayList<Context> LoadContext(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadContext(xmlDocument);
    }
    public ArrayList<Context> LoadContext(Document xmlDocument)
    {
        var contextList = new ArrayList<Context>();
        var rootNode = xmlDocument.getLastChild();
        var contextNodes = rootNode.getChildNodes();
        for (int i = 0; i < contextNodes.getLength(); i++) {
            UUID guid = null;
            SerialNumber currentScenario = null;
            SerialNumber currentScene = null;
            SerialNumber currentCaption = null;

            var contextNode = contextNodes.item(i);
            if(!contextNode.getNodeName().equals("Context")) {
                continue;
            }
            var propertyNodes = contextNode.getChildNodes();
            for (int j = 0; j < propertyNodes.getLength(); j++) {
                var propertyNode = propertyNodes.item(j);
                switch (propertyNode.getNodeName()) {
                    case "GUID":
                        guid = UUID.fromString(propertyNode.getTextContent());
                        break;
                    case "CurrentScenario":
                        currentScenario = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "CurrentScene":
                        currentScene = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "CurrentCaption":
                        currentCaption = new SerialNumber(propertyNode.getTextContent());
                        break;
                }
            }

            var context = new Context(guid);
            context.CurrentScenario = currentScenario;
            context.CurrentScene = currentScene;
            context.CurrentCaption = currentCaption;
            contextList.add(context);
        }
        return contextList;
    }

    public ArrayList<Caption> LoadCaption(String filePath)
    {
        Document xmlDocument = null;
        try {
            xmlDocument = OpenXml(filePath);
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        }
        return LoadCaption(xmlDocument);
    }
    public ArrayList<Caption> LoadCaption(Document xmlDocument)
    {
        var captionList = new ArrayList<Caption>();
        var rootNode = xmlDocument.getLastChild();
        var captionNodes = rootNode.getChildNodes();
        for (int i = 0; i < captionNodes.getLength(); i++) {
            SerialNumber serialNumber = null;
            String dialogue = "";
            var dialogueParameter = new ArrayList<SerialNumber>();
            SerialNumber cause = null;
            String speakerName = "";
            SerialNumber option = null;
            SerialNumber nextCaption = null;
            boolean displayed = false;

            var captionNode = captionNodes.item(i);
            if(!captionNode.getNodeName().equals("Caption")) {
                continue;
            }
            var propertyNodes = captionNode.getChildNodes();
            for (int j = 0; j < propertyNodes.getLength(); j++) {
                var propertyNode = propertyNodes.item(j);
                switch (propertyNode.getNodeName()) {
                    case "SerialNumber":
                        serialNumber = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Dialogue":
                        dialogue = propertyNode.getTextContent();
                        break;
                    case "Displayed":
                        displayed = Boolean.parseBoolean(propertyNode.getTextContent());
                        break;
                    case "DialogueParameters":
                        var sceneNodes = propertyNode.getChildNodes();
                        for (int k = 0; k < sceneNodes.getLength(); k++) {
                            if(!sceneNodes.item(k).getNodeName().equals("DialogueParameter")) {
                                continue;
                            }
                            dialogueParameter.add(new SerialNumber(sceneNodes.item(k).getTextContent()));
                        }
                        break;
                    case "Cause":
                        cause = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "SpeakerName":
                        speakerName = propertyNode.getTextContent();
                        break;
                    case "NextCaption":
                        nextCaption = new SerialNumber(propertyNode.getTextContent());
                        break;
                    case "Option":
                        option = new SerialNumber(propertyNode.getTextContent());
                        break;
                }
            }

            SerialNumber[] arrDialogueParameters = new SerialNumber[dialogueParameter.size()];
            arrDialogueParameters = dialogueParameter.toArray(arrDialogueParameters);
            if ((cause == null) && (option == null))
            {// without Cause and Option
                var caption = new Caption(serialNumber, dialogue, arrDialogueParameters,
                        speakerName, nextCaption, displayed);
                captionList.add(caption);
            }
            else if ((cause != null) && (option == null))
            {// with Cause, without Option
                var caption = new Caption(serialNumber, dialogue, arrDialogueParameters,
                        speakerName, nextCaption, displayed, cause, true);
                captionList.add(caption);
            }
            else if ((cause == null) && (option != null))
            {// with Option, without Cause
                var caption = new Caption(serialNumber, dialogue, arrDialogueParameters,
                        speakerName, nextCaption, displayed, option);
                captionList.add(caption);
            }
            else
            {// with Cause and Option
                var caption = new Caption(serialNumber, dialogue, arrDialogueParameters,
                        speakerName, nextCaption, displayed, cause, option);
                captionList.add(caption);
            }
        }
        return captionList;
    }

    private Document OpenXml(String filePath) throws ParserConfigurationException, IOException, SAXException {
        try {
            File file = new File(filePath);
            DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
            dbFactory.setIgnoringComments(true);
            dbFactory.setIgnoringElementContentWhitespace(true);
            DocumentBuilder docBuild = dbFactory.newDocumentBuilder();
            Document doc = docBuild.parse(file);
            doc.getDocumentElement().normalize();
            return doc;
        } catch (ParserConfigurationException e) {
            throw e;
        } catch (IOException e) {
            throw e;
        } catch (SAXException e) {
            throw e;
        }
    }
}
