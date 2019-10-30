using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneForCastController : MonoBehaviour
{
    [SerializeField]
    private int frontZ, backZ, time;


    private int center, range;

    // Start is called before the first frame update
    void Start()
    {
        center = (frontZ + backZ) / 2;
        range = (frontZ - backZ) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newMyPosition = this.transform.position;
        newMyPosition.z = center + Mathf.Sin(time * Time.time) * range;
        this.transform.position = newMyPosition;
        
    }
}
