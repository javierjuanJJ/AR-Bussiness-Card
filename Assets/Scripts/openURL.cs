using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openURL : MonoBehaviour
{
    public void openURLMethod(string URL)
    {
        Application.OpenURL(URL);
    }
    
}
