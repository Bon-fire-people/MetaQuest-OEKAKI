using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundRect : MonoBehaviour
{
    private Texture _texture;

    private void Start()
    {
        var texture = new Texture2D(1, 1);
        texture.SetPixel(0, 0, Color.white);
        texture.Apply();
        _texture = texture;
    }

    private void OnGUI()
    {
        var rect = new Rect(12, 12, 300, 100);
        GUI.DrawTexture(rect, _texture, ScaleMode.StretchToFill, true, 0, Color.red, 0, 12);
    }
}
