using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreation : MonoBehaviour
{
    public Transform myPrefab;
    ArrayList list;
    Vector3 vector; 
    Transform clone;
    public GameObject parent;
   
    void Start()
    {
        list = new ArrayList();
        for (int i=0; i<5; i++) {
            do {
                vector = new Vector3(UnityEngine.Random.Range(-5,5)/100f,0.01f,UnityEngine.Random.Range(-5,5)/100f);
            } while (list.Contains(vector));
            clone = Instantiate(myPrefab,vector,new Quaternion(0,0,0,1));
	    clone.parent = parent.transform;
            list.Add(vector);
        }
    }
}
