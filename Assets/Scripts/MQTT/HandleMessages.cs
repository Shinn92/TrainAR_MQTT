using Unity.VisualScripting;
using UnityEngine;

namespace Visual_Scripting
{
    /// <summary>
    /// Registering a string name for your custom event to hook it to an event. You can save this class in a separated file and add multiple events to it as public static strings.
    /// </summary>
    public static class VisualScriptingEventNames_messages
    {
        public static string MessageWasReceived = "OnMessageReceived";
    }
    /// <summary>
    /// Adds an EventHook for receiving MQTT Messages
    /// </summary>
    [UnitTitle("TrainAR: MessageReceived")]//Custom Event node to receive the event. Adding On to the node title as an event naming convention.
    [UnitCategory("Events")]//Setting the path to find the node in the fuzzy finder in Events > My Events.
    public class MessageWasReceived : EventUnit<bool>
    {
        
        protected override bool register => true;
        /// <summary>
        /// Adding an EventHook with the name of the event to the list of visual scripting events.
        /// </summary>
        /// 
       
        /// <param name="reference"></param>
        /// <returns>The event for visual scripting.</returns>
        public override EventHook GetHook(GraphReference reference)
        {
            Debug.Log("Event received: " + VisualScriptingEventNames_messages.MessageWasReceived); // Debugging statement
            return new EventHook(VisualScriptingEventNames_messages.MessageWasReceived);
        }
        
    }
}