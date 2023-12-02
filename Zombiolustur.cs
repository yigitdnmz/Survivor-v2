using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombiolustur : MonoBehaviour
{
    public GameObject zombi;
    private float zamansayaci;
    private float olusumsureci = 10f;
    // Start is called before the first frame update
    void Start()
    {
        zamansayaci = olusumsureci;
    }

    // Update is called once per frame
    void Update()
    {
        zamansayaci -= Time.deltaTime;
        if (zamansayaci < 0 ) {
            Vector3 pos = new Vector3 (Random.Range(180f,31f),22.80f,Random.Range(407f,20f));
            Instantiate (zombi, pos, Quaternion.identity);
            zamansayaci = olusumsureci;
        }
    }
}
