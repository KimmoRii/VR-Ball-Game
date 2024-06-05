using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnHover : MonoBehaviour
{
    public Material defaultMaterial;
    public Material newMaterial;

    Renderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<Renderer>();
    }

    public void HoverEnter()
    {
        meshRenderer.material = newMaterial;
    }

    public void HoverExit()
    {
        meshRenderer.material = defaultMaterial;
    }
}
