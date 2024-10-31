using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Content.Interaction;

public class CheckCorrect : MonoBehaviour
{
    public XRKnob[] knobs;
    public UnityEvent onCorrect;
    private void Update() {
        check();
    }
    public void check(){
        for (int i = 0; i < knobs.Length; i++)
        {
            if (!(knobs[i].value >= 0.64f && knobs[i].value <= 0.67f))
            {
                break;
            }else if (i == knobs.Length - 1)
            {
                for (int j = 0; j < knobs.Length; j++)
                {
                    knobs[i].value = 0.6516837f;
                }
                onCorrect.Invoke();
            }
        }
    }
}
