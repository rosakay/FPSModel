using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    Renderer rend;
    float val;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        // Use the Specular shader on the material
        rend.material.shader = Shader.Find("Examples/SimpleDissolveAlpha");
    }

    // Update is called once per frame
    void Update()
    {
        // Animate the Shininess value
        val += 0.3f * Time.deltaTime;
        rend.material.SetFloat("_DissolveValue", val);
    }
}
