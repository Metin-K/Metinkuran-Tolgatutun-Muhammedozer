using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using static System.Net.Mime.MediaTypeNames;

public class vbInteraction : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public GameObject firstPanel, eiffel;


    private object ngo;

    
    void Start()
    {
	// We get start function from internet
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);

    }

    // Update is called once per frame
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

	// Deactivate if button is active
        Deactivate();
        if (vbName == "VirtualButton1")
        {
            Btn1();

        }



    }
    void Deactivate()
    {
        eiffel.SetActive(false);
    }

   // Set button active
    void Btn1()
    {
        eiffel.SetActive(true);
    }

    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }
}
