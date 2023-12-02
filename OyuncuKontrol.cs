using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform mermiPos;
    public GameObject mermi;
    public GameObject canbar;
    public float can;
    void Start()
    {
        can = 100;
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.F)){
            GameObject go = Instantiate(mermi, mermiPos.position, mermiPos.rotation) as GameObject;
            go.GetComponent<Rigidbody> ().velocity = mermiPos.transform.forward * 10f;
            Destroy (go.gameObject, 2f);
            canbar.transform.localScale = new Vector3 (0.5f, 1, 1);
            if (can >= 100)
            {
                can = 100;
            }
            if (can <= 0)
            {
                can = 0;
            }
        }
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("zombi"))
        {
            Debug.Log("zombi saldirida");
            can -= 10;
        }
    }
}
