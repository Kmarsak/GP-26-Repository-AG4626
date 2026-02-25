using JetBrains.Annotations;
using UnityEngine;

public class TriggerTestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light directionalLight;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered trigger!");
        directionalLight.enabled = !directionalLight.enabled;
    }
    void Start()
    {
        Debug.Log("Script started!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
