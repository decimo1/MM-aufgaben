﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageHandler : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager _trackedImageManager;
   // [SerializeField] GameObject _player;
   // [SerializeField] GameObject _surface;
    [SerializeField] GameObject _parent;
    private void Start()
    {
        if(!_trackedImageManager) {
	    _trackedImageManager = GetComponent<ARTrackedImageManager>();
	}
    }

    void OnEnable() => _trackedImageManager.trackedImagesChanged += OnChanged;
    void OnDisable() => _trackedImageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs){
	foreach(var trackedImage in eventArgs.added){
            var minLocalScalar = Mathf.Min(trackedImage.size.x, trackedImage.size.y) / 2;
            trackedImage.transform.localScale = new Vector3(minLocalScalar, minLocalScalar, minLocalScalar);
	    _parent.transform.parent = trackedImage.transform; 
	    //_surface.transform.parent = trackedImage.transform;
	    //_surface.transform.localScale = Vector3.one;
	    //_player.transform.parent = trackedImage.transform;
	    //_player.transform.localScale = Vector3.one;
        }
    }
}
