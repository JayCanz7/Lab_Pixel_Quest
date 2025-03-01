using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    public int var1 = 15;
    // Start is called before the first frame update
  
    void Start()
    {
        // var2 is declared and assigned to 3
        int var2 = 3;
        // print this out
        Debug.Log("Hello World" + var1 + var2);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var1);
        var1++;
    }
}
