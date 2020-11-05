using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageHandler : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager _trackedImageManager;
    [SerializeField] GameObject _content;

    private void Start()
    {
        if(!_trackedImageManager) {
	    _trackedImageManager = GetComponent<ARTrackedImageManager>();
	}
    }

    //void OnEnable() => _trackedImageManager.trackedImagesChanged += OnChanged;
    //void OnDisable() => _trackedImageManager.trackedImagesChanged -= OnChanged;
}
