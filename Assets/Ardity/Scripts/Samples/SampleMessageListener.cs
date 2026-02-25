/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using System;
using UnityEngine;
using System.Collections;
 
/**
 * When creating your message listeners you need to implement these two methods:
 *  - OnMessageArrived
 *  - OnConnectionEvent
 */

public class SampleMessageListener : MonoBehaviour
{
    GameObject PlayerObject;
    int led; 
    private void Start()
    {
        PlayerObject= GameObject.FindWithTag("Player");
    }

    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        //This is to show, what would have been done if hardware had worked 
        //Sucess = bool.Parse(msg);
        //ComboSucess = float.Parse(msg);

        {
            /*
            var LedNumber = msg.IndexOf(",");
            var messageTemp = msg;
            if (msg.Contains("Active"))
            {
                messageTemp = msg.Remove(LedNumber, msg.Length);
                messageTemp = msg.Replace("Active", "");
                led = Int32.Parse(messageTemp);
            }
            print(led);
            print(messageTemp);
            switch (led)
            {
                case 10:
                    Debug.Log("Light Attack");
                    break;
                case 11:
                    Debug.Log("Med Attack");
                    break;
                case 12:
                    Debug.Log("Heavy Attack");
                    break;
                case 13:
                    Debug.Log("Special Attack");
                    break;
            }
            */
        }
            
       
       Debug.Log("Message arrived: " + msg);
    }

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }
}
