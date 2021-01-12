using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class OptimizeFinalBlitTest : MonoBehaviour
{
    public Text Text;
    // Update is called once per frame
    void Update()
    {
        Text.text = $"OptimizeFinalBlit:{ForwardRenderer.OptimizeFinalBlit}";
    }

    public void OnClick()
    {
        ForwardRenderer.OptimizeFinalBlit = !ForwardRenderer.OptimizeFinalBlit;
    }
}
