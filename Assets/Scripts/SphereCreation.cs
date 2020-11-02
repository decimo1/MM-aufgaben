using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreation : MonoBehaviour
{
    public Transform myPrefab;
    ArrayList list;
    Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {
        list = new ArrayList();
        for (int i=0; i<10; i++) {
            do {
                vector = new Vector3(UnityEngine.Random.Range(-10,10),1,UnityEngine.Random.Range(-10,10));
            } while (list.Contains(vector));
            Instantiate(myPrefab,vector,new Quaternion(0,0,0,1));
            list.Add(vector);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
