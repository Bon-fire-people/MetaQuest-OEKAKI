using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActivate : MonoBehaviour
{
    [SerializeField]private GameObject _menu;
    [SerializeField] private GameObject _UIHelper;

    // Start is called before the first frame update
    void Start()
    {
        _menu.SetActive(false);
        _UIHelper.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))
        {
            _menu.SetActive(true);
            _UIHelper.SetActive(true);
        }

        if (OVRInput.Get(OVRInput.RawButton.LHandTrigger))
        {
            _menu.SetActive(true);
            _UIHelper.SetActive(true);
        }

        if (OVRInput.GetUp(OVRInput.RawButton.LHandTrigger))
        {
            _menu.SetActive(false);
            _UIHelper.SetActive(false);
        }
    }
}
