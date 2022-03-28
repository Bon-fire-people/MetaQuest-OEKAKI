using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRenderer : MonoBehaviour
{

    [SerializeField] private GameObject LinePrefab;
    [SerializeField] private Transform HandAnchor;
    [SerializeField] private Material _lineMat;
    private int LineCt;
    private LineRenderer Render;
    private GameObject CurrentLineObject;

    private Transform Pointer
    {
        get
        {
            return HandAnchor;
        }
    }

    public void setMaterial(Material _mat)
    {
        _lineMat = _mat;
    }

    // Update is called once per frame
    void Update()
    {

        if (!OVRInput.Get(OVRInput.RawButton.LHandTrigger))
        {
            if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
            {

                var pointer = Pointer;
                if (pointer == null)
                {
                    Debug.Log("pointer not defiend");
                    return;
                }


                if (CurrentLineObject == null)
                {
                    CurrentLineObject = Instantiate(LinePrefab, new Vector3(0, 0, 0), Quaternion.identity);
                    Render = CurrentLineObject.GetComponent<LineRenderer>();
                    Render.material = new Material(_lineMat);
                    LineCt += 1;
                    Render.name = Render.name + LineCt;
                }

                if (Render != null)
                {
                    //LineRendererからPositionsのサイズを取得
                    int NextPositionIndex = Render.positionCount;

                    //LineRendererのPositionsのサイズを増やす
                    Render.positionCount = NextPositionIndex + 1;

                    //LineRendererのPositionsに現在のコントローラーの位置情報を追加
                    Render.SetPosition(NextPositionIndex, pointer.position);
                }

            }
            else if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger))//人差し指のトリガーを離したとき
            {
                if (CurrentLineObject != null)
                {
                    //現在描画中の線があったらnullにして次の線を描けるようにする。
                    CurrentLineObject = null;
                }
            }

        }
    }
}
