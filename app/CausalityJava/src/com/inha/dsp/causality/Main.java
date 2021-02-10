package com.inha.dsp.causality;

import com.inha.dsp.causality.type.*;
import com.inha.dsp.causality.util.XmlLoader;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
	    XmlLoader loader = new XmlLoader();
	    String rootPath = "D:\\REPO\\Causality\\xml\\";
	    ArrayList<Role> roles = loader.LoadRole(rootPath + "role.xml");
		ArrayList<Action> actions = loader.LoadAction(rootPath + "action.xml");
		ArrayList<CustomAction> customactions = loader.LoadCustomAction(rootPath + "customaction.xml");
		ArrayList<Perceptron> perceptrons = loader.LoadPerceptron(rootPath + "perceptron.xml");
		ArrayList<Cause> causes = loader.LoadCause(rootPath + "cause.xml");
		ArrayList<Option> options = loader.LoadOption(rootPath + "option.xml");
		ArrayList<Scene> scenes = loader.LoadScene(rootPath + "scene.xml");
		ArrayList<Scenario> scenarios = loader.LoadScenario(rootPath + "scenario.xml");
		ArrayList<Context> contexts = loader.LoadContext(rootPath + "context.xml");
		ArrayList<Caption> captions = loader.LoadCaption(rootPath + "caption.xml");

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
		for(Caption caption: captions) {
			System.out.printf("SerialNumber: %s, Dialogue: %s, SpeakerName: %s, Displayed: %s\n",
					caption.getSerialNumber(), caption.getDialogue(), caption.getSpeakerName(), caption.Displayed);
			System.out.printf("HasCause: %s, Cause: %s, Option: %s, NextCaption: %s\n",
					caption.hasCause(), caption.getCause(), caption.getOption(), caption.getNextCaption());
			for(SerialNumber dp : caption.DialogueParameter) {
				System.out.printf("DialogueParameter: %s\t", dp);
			} System.out.println();
		}
	}

	private static void printContexts(java.util.ArrayList<com.inha.dsp.causality.type.Context> contexts) {
		for(Context context: contexts) {
			System.out.printf("GUID: %s, CurrentScenario: %s, CurrentScene: %s, CurrentCaption: %s\n",
					context.getGUID(), context.CurrentScenario, context.CurrentScene, context.CurrentCaption);
		}
	}

	private static void printScenarios(java.util.ArrayList<com.inha.dsp.causality.type.Scenario> scenarios) {
		for(Scenario scenario: scenarios) {
			System.out.printf("SerialNumber: %s, Description: %s, Displayed: %s\n",
					scenario.getSerialNumber(), scenario.getDescription(), scenario.Displayed);
			for(SerialNumber scene : scenario.Scenes) {
				System.out.printf("Scene: %s\t", scene);
			} System.out.println();
		}
	}

	private static void printScenes(java.util.ArrayList<com.inha.dsp.causality.type.Scene> scenes) {
		for(Scene scene: scenes) {
			System.out.printf("SerialNumber: %s, Description: %s, Caption: %s, Displayed: %s\n",
					scene.getSerialNumber(), scene.getDescription(), scene.getCaption(), scene.Displayed);
		}
	}

	private static void printOptions(java.util.ArrayList<com.inha.dsp.causality.type.Option> options) {
		for(Option option : options) {
			System.out.printf("SerialNumber: %s, Description: %s, isMultiple: %s\n",
					option.getSerialNumber(), option.getDescription(), option.isMultiple());
			for(SerialNumber action : option.Actions) {
				System.out.printf("Action: %s\t", action);
			} System.out.println();
		}
	}

	private static void printCauses(java.util.ArrayList<com.inha.dsp.causality.type.Cause> causes) {
		for(Cause cause : causes) {
			System.out.printf("SerialNumber: %s, Description: %s, perceptron: %s\n",
					cause.getSerialNumber(), cause.getDescription(), cause.getPerceptron());
			for(SerialNumber next : cause.Next) {
				System.out.printf("Next: %s\t", next);
			} System.out.println();
			for(double threshold : cause.Thresholds) {
				System.out.printf("Threshold: %f\t", threshold);
			} System.out.println();
		}
	}

	private static void printPerceptrons(java.util.ArrayList<com.inha.dsp.causality.type.Perceptron> perceptrons) {
		for(Perceptron perceptron : perceptrons) {
			System.out.printf("SerialNumber: %s, Description: %s, Bias: %f\n",
					perceptron.getSerialNumber(), perceptron.getDescription(), perceptron.getBias());
			for(SerialNumber input : perceptron.Inputs) {
				System.out.printf("Input: %s\t", input);
			} System.out.println();
			for(double weight : perceptron.Weights) {
				System.out.printf("Weight: %f\t", weight);
			} System.out.println();
		}
	}

	private static void printCustomActions(java.util.ArrayList<com.inha.dsp.causality.type.CustomAction> customactions) {
		for(CustomAction action: customactions) {
			System.out.printf("SerialNumber: %s, ActorName: %s, Description: %s, DefaultValue: %s\n",
					action.getSerialNumber(), action.getActorName(), action.getDescription(),
					action.getDefaultValue());
		}
	}

	private static void printActions(java.util.ArrayList<com.inha.dsp.causality.type.Action> actions) {
		for(Action action: actions) {
			System.out.printf("SerialNumber: %s, ActorName: %s, Description: %s, DefaultValue: %s\n",
					action.getSerialNumber(), action.getActorName(), action.getDescription(),
					action.getDefaultValue());
		}
	}

	private static void printRoles(java.util.ArrayList<com.inha.dsp.causality.type.Role> roles) {
		for(Role role: roles) {
			System.out.printf("SerialNumber: %s, Name: %s, Description: %s, Position: %s\n",
					role.getSerialNumber(), role.getName(), role.getDescription(),
					role.getPosition());
		}
	}
}
