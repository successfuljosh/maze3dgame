using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int Score = 0;
    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 120, 140), "Move around to\n complete\n the maze. \nCollect capsules \nto earn points \n\nScore" + "\n" + Score.ToString());
    }
}
