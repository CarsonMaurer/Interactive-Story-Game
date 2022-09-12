using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject 
{
        [TextArea(10,14)] [Serializefield] string storyText;
        [Serializefield] State[] nextState;

        public string GetStateStory()
        {
            return storyText;
        }
        public State[] GetNextStates()
        {
            return nextStates;
        }
}
