﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(IngameVideoRecorder))]
public class IngameVideoRecorderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var recorederObject = (IngameVideoRecorder)target;
        string recordingState = "Recording state: ";
        recordingState += (recorederObject.recording == true) ? " Recording" : " Not Recording";
        GUILayout.Label(recordingState);

        if (GUILayout.Button("Open Video Save Location"))
        {
            System.Diagnostics.Process.Start(recorederObject.savePath.Replace("\"", ""));
        }

    }
}
