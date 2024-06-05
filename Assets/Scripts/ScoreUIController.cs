using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    [SerializeField] GameObject canvas;

    void Start()
    {
        canvas.SetActive(false);
    }

    public void OnScore()
    {
        canvas.SetActive(!canvas.activeInHierarchy);
    }
}
