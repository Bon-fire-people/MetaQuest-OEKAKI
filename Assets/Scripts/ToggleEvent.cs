using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleEvent : MonoBehaviour
{
    [SerializeField] private lineRenderer _linerenderer;
    [SerializeField] private MeshRenderer _meshrenderer;
    [SerializeField] Material _material;
    Toggle toggle;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
        _linerenderer.setMaterial(_material);
    }

    public void lineMatChange()
    {
        if(toggle.isOn)
        {
            _linerenderer.setMaterial(_material);
            _meshrenderer.material = _material;
        }
    }

}
