using System;
using UnityEngine;
using UnityEngine.UI;

public class ArNoteMB : MonoBehaviour {
    public float noteDistanceFromCamera = 10;
    private GameObject arCamera;
    public String savePositionButtonName = "SavePositionButton";
    public bool isPositioningState = true;
    
    void Start()
    {
        arCamera = GameObject.Find("ARCamera");
        GameObject.Find(savePositionButtonName).GetComponent<Button>().onClick.AddListener(SavePosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPositioningState)
        {
            Transform cameraTransform = arCamera.transform;
            gameObject.transform.position = cameraTransform.position + cameraTransform.forward * noteDistanceFromCamera;
        }
    }

    void SavePosition()
    {
        Debug.Log("OnSavePosition click");
        isPositioningState = false;
    }
}
