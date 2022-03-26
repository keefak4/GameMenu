using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class GameMenu : EditorWindow
{
    [MenuItem("Game/DelPlayerPR")]
    public static void RemovePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
    [MenuItem("Game/Screenshot")]
    public static void ScreemShotClick()
    {
        string path = "Screenshot";
        Directory.CreateDirectory(path);
        int i = 0;
        while(File.Exists(path + "/" + i + ".png"))
        {
            i++;
        }
        ScreenCapture.CaptureScreenshot(path + "/" + i + ".png");
    }
}
