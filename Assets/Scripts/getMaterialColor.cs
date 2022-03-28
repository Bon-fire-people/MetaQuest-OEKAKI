using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getMaterialColor : MonoBehaviour
{
    private string _color;
    [SerializeField] private Material _mat;
    [SerializeField] private Toggle _toggle;

    private void Start()
    {
        _mat.color = new Color(0f, 0f, 0f, 1f);
    }

    public void getColorValue(Slider slider)
    {
        float _r = _mat.color.r;
        float _g = _mat.color.g;
        float _b = _mat.color.b;
        float _a = _mat.color.a;

        if (_toggle.isOn)
        {
            switch (_color)
            {
                case "R":
                    _r = slider.value / 255;
                    break;
                case "G":
                    _g = slider.value / 255;
                    break;
                case "B":
                    _b = slider.value / 255;
                    break;
                case "A":
                    _a = slider.value / 255;
                    break;
                default:
                    break;
            }

            _color = "";
            _mat.color = new Color(_r, _g, _b, _a);

        }
    }

    public void getColor(string color)
    {
        if (_toggle.isOn)
        {
            _color = color;
        }
    }

    public void setPreviewMat(Material _material)
    {
        gameObject.GetComponent<MeshRenderer>().material = _material;
    }
}
