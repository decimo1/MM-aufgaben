using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreation : MonoBehaviour
{
    public Transform myPrefab;
    ArrayList list;
    Vector3 vector;
    Vector3 scaleVector;

    // Start is called before the first frame update
    void Start()
    {
	//scaleVector = new Vector3(0.01f,0.01f,0.01f);
        list = new ArrayList();
        for (int i=0; i<5; i++) {
            do {
                vector = new Vector3(UnityEngine.Random.Range(-5,5)/100,1,UnityEngine.Random.Range(-5,5)/100);
            } while (list.Contains(vector));
            Instantiate(myPrefab,vector,new Quaternion(0,0,0,1));
            list.Add(vector);
        }
    }
}
