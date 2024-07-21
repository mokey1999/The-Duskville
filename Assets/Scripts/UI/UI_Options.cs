using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Options : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }
    public void SaveAndExit()
    {
        SaveManager.instance.SaveGame();
        Application.Quit();

#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
