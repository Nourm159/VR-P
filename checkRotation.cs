using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class checkRotation : MonoBehaviour
{
    public XRKnob knob;
    private void Update() {
        RotationT();
    }
    public void RotationT(){
        Vector3 KnobRot = new Vector3 (-90, 180 * Mathf.Lerp(-1,1,knob.value), 0);
        transform.localRotation = Quaternion.Euler(KnobRot);
    }
}
