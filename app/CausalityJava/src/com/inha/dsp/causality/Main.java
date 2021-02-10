package com.inha.dsp.causality;

import com.inha.dsp.causality.util.XmlLoader;

public class Main {

    public static void main(String[] args) {
	    var loader = new XmlLoader();
	    String rootPath = "D:\\REPO\\Causality\\xml\\";
	    var roles = loader.LoadRole(rootPath + "role.xml");
	    var actions = loader.LoadAction(rootPath + "action.xml");
	    var customactions = loader.LoadCustomAction(rootPath + "customaction.xml");
	    var perceptrons = loader.LoadPerceptron(rootPath + "perceptron.xml");
		var causes = loader.LoadCause(rootPath + "cause.xml");
		var options = loader.LoadOption(rootPath + "option.xml");
		var scenes = loader.LoadScene(rootPath + "scene.xml");
		var scenarios = loader.LoadScenario(rootPath + "scenario.xml");
		var contexts = loader.LoadContext(rootPath + "context.xml");
		var captions = loader.LoadCaption(rootPath + "caption.xml");

		printRoles(roles);
		printActions(actions);
		printCustomActions(customactions);
		printPerceptrons(perceptrons);
		printCauses(causes);
		printOptions(options);
		printScenes(scenes);
		printScenarios(scenarios);
		printContexts(contexts);
		printCaptions(captions);
	}

	private static void printCaptions(java.util.ArrayList<com.inha.dsp.causality.type.Caption> captions) {
		for(var caption: captions) {
			System.out.printf("SerialNumber: %s, Dialogue: %s, SpeakerName: %s, Displayed: %s\n",
					caption.getSerialNumber(), caption.getDialogue(), caption.getSpeakerName(), caption.Displayed);
			System.out.printf("HasCause: %s, Cause: %s, Option: %s, NextCaption: %s\n",
					caption.hasCause(), caption.getCause(), caption.getOption(), caption.getNextCaption());
			for(var dp : caption.DialogueParameter) {
				System.out.printf("DialogueParameter: %s\t", dp);
			} System.out.println();
		}
	}

	private static void printContexts(java.util.ArrayList<com.inha.dsp.causality.type.Context> contexts) {
		for(var context: contexts) {
			System.out.printf("GUID: %s, CurrentScenario: %s, CurrentScene: %s, CurrentCaption: %s\n",
					context.getGUID(), context.CurrentScenario, context.CurrentScene, context.CurrentCaption);
		}
	}

	private static void printScenarios(java.util.ArrayList<com.inha.dsp.causality.type.Scenario> scenarios) {
		for(var scenario: scenarios) {
			System.out.printf("SerialNumber: %s, Description: %s, Displayed: %s\n",
					scenario.getSerialNumber(), scenario.getDescription(), scenario.Displayed);
			for(var scene : scenario.Scenes) {
				System.out.printf("Scene: %s\t", scene);
			} System.out.println();
		}
	}

	private static void printScenes(java.util.ArrayList<com.inha.dsp.causality.type.Scene> scenes) {
		for(var scene: scenes) {
			System.out.printf("SerialNumber: %s, Description: %s, Caption: %s, Displayed: %s\n",
					scene.getSerialNumber(), scene.getDescription(), scene.getCaption(), scene.Displayed);
		}
	}

	private static void printOptions(java.util.ArrayList<com.inha.dsp.causality.type.Option> options) {
		for(var option : options) {
			System.out.printf("SerialNumber: %s, Description: %s, isMultiple: %s\n",
					option.getSerialNumber(), option.getDescription(), option.isMultiple());
			for(var action : option.Actions) {
				System.out.printf("Action: %s\t", action);
			} System.out.println();
		}
	}

	private static void printCauses(java.util.ArrayList<com.inha.dsp.causality.type.Cause> causes) {
		for(var cause : causes) {
			System.out.printf("SerialNumber: %s, Description: %s, perceptron: %s\n",
					cause.getSerialNumber(), cause.getDescription(), cause.getPerceptron());
			for(var next : cause.Next) {
				System.out.printf("Next: %s\t", next);
			} System.out.println();
			for(var threshold : cause.Thresholds) {
				System.out.printf("Threshold: %f\t", threshold);
			} System.out.println();
		}
	}

	private static void printPerceptrons(java.util.ArrayList<com.inha.dsp.causality.type.Perceptron> perceptrons) {
		for(var perceptron : perceptrons) {
			System.out.printf("SerialNumber: %s, Description: %s, Bias: %f\n",
					perceptron.getSerialNumber(), perceptron.getDescription(), perceptron.getBias());
			for(var input : perceptron.Inputs) {
				System.out.printf("Input: %s\t", input);
			} System.out.println();
			for(var weight : perceptron.Weights) {
				System.out.printf("Weight: %f\t", weight);
			} System.out.println();
		}
	}

	private static void printCustomActions(java.util.ArrayList<com.inha.dsp.causality.type.CustomAction> customactions) {
		for(var action: customactions) {
			System.out.printf("SerialNumber: %s, ActorName: %s, Description: %s, DefaultValue: %s\n",
					action.getSerialNumber(), action.getActorName(), action.getDescription(),
					action.getDefaultValue());
		}
	}

	private static void printActions(java.util.ArrayList<com.inha.dsp.causality.type.Action> actions) {
		for(var action: actions) {
			System.out.printf("SerialNumber: %s, ActorName: %s, Description: %s, DefaultValue: %s\n",
					action.getSerialNumber(), action.getActorName(), action.getDescription(),
					action.getDefaultValue());
		}
	}

	private static void printRoles(java.util.ArrayList<com.inha.dsp.causality.type.Role> roles) {
		for(var role: roles) {
			System.out.printf("SerialNumber: %s, Name: %s, Description: %s, Position: %s\n",
					role.getSerialNumber(), role.getName(), role.getDescription(),
					role.getPosition());
		}
	}
}
