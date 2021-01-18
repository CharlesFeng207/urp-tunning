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
        Text.text = $"OptimizeFinalBlit:{ScriptableRenderer.OptimizeFinalBlit}";
    }

    public void OnClick()
    {
        ScriptableRenderer.OptimizeFinalBlit = !ScriptableRenderer.OptimizeFinalBlit;
    }
}
