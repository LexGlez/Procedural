using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class procedura : MonoBehaviour
{
    public GameObject camino;
    int a;
    void Start()
    {
        
    }

    void Update(){}

    public void proceso(){
        
        a+=9;
        Instantiate(camino, new Vector3(0, 0, a), Quaternion.identity);
    }
}
