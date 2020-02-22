using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stimSelect : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TMP_Dropdown dropdown;
    private List<string> options = new List<string> { "DefaultBlack", "OMR", "RandomDot" };
    private int whichStim;
    public Camera stimCam;
    public Camera stimSubCam;

    public void closeAllCams()
    {
        for (int i = 0; i < options.Count; i++)
        {
            Camera camToClose = GameObject.Find(options[i]+"Cam").GetComponent<Camera>();
            Camera subCamToClose = GameObject.Find(options[i] + "SubCam").GetComponent<Camera>();
            camToClose.enabled = false;
            subCamToClose.enabled = false;
        }
        
    }
    public void stimStart(int index)
    {

        closeAllCams();
        stimCam = GameObject.Find(options[index]+"Cam").GetComponent<Camera>();
        stimSubCam = GameObject.Find(options[index] + "SubCam").GetComponent<Camera>();
        stimCam.enabled = true;
        stimSubCam.enabled = true;
    }
}
