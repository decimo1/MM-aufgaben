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

    void OnEnable() => _trackedImageManager.trackedImagesChanged += OnChanged;
    void OnDisable() => _trackedImageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs){
	foreach(var trackedImage in eventArgs.added){
            var minLocalScalar = Mathf.Min(trackedImage.size.x, trackedImage.size.y) / 2;
            trackedImage.transform.localScale = new Vector3(minLocalScalar, minLocalScalar, minLocalScalar);
	    _content.transform.parent = trackedImage.transform;
	    _content.transform.localScale = Vector3.one;
        }
    }
}
