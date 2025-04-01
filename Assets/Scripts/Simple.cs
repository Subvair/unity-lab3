using System.Collections.Generic;
using UnityEngine;

public class Simple : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake called");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable called");
    }

    void Start()
    {
        Debug.Log("Start called");
    }

    void Update()
    {
        Debug.Log("Update called");
    }

    void LateUpdate()
    {
        Debug.Log("LateUpdate called");
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate called");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable called");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy called");
    }
}
