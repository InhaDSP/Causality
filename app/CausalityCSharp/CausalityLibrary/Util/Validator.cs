using System;
using System.Collections.Generic;
using System.Linq;
using CausalityLibrary.Type;

namespace CausalityLibrary.Util
{
    public class Validator
    {
        private static bool CheckElements<T, TProp>(IEnumerable<T> container, Func<T, TProp> comparator)
        {
            var duplicates = container
                .GroupBy(x => comparator(x))
                .Any(g => g.Count() > 1);
            if (duplicates)
            {
                return true;
            }
            return false;
        }

        public static bool InvalidRoles(IEnumerable<Role> roles)
        {
            var duplicates = CheckElements(roles, (elem => elem.SerialNumber.Index));
            return duplicates;
        }

        public static bool InvalidActions(IEnumerable<Type.Action> actions)
        {
            var duplicates = CheckElements(actions, (elem => elem.SerialNumber.Index));
            return duplicates;
        }

        public static bool InvalidCustomActions(IEnumerable<Type.CustomAction> customActions)
        {
            var duplicates = CheckElements(customActions, (elem => elem.SerialNumber.Index));
            return duplicates;
        }

        public static bool InvalidEmotionalActions(IEnumerable<Type.EmotionalAction> emotionalActions)
        {
            var duplicates = CheckElements(emotionalActions, (elem => elem.SerialNumber.Index));
            return duplicates;
        }

        public static bool InvalidPerceptrons(IEnumerable<Perceptron> perceptrons)
        {
            var duplicates = CheckElements(perceptrons, (elem => elem.SerialNumber.Index));
            return duplicates;
        }

        public static bool InvalidCauses(IEnumerable<Cause> causes)
        {
            var duplicates = CheckElements(causes, (elem => elem.SerialNumber.Index));
            return duplicates;
        }

        public static bool InvalidOptions(IEnumerable<Option> options)
        {
            var duplicates = CheckElements(options, (elem => elem.SerialNumber.Index));
            return duplicates;
        }
        
        public static bool InvalidCaptions(IEnumerable<Caption> captions)
        {
            var duplicates = CheckElements(captions, (elem => elem.SerialNumber.Index));
            return duplicates;
        }
        
        public static bool InvalidScenes(IEnumerable<Scene> scenes)
        {
            var duplicates = CheckElements(scenes, (elem => elem.SerialNumber.Index));
            return duplicates;
        }

        public static bool InvalidScenarios(IEnumerable<Scenario> scenarios)
        {
            var duplicates = CheckElements(scenarios, (elem => elem.SerialNumber.Index));
            return duplicates;
        }
    }
}
