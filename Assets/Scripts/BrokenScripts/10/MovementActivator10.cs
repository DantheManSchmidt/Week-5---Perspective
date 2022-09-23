using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator10 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
     //Capitalized "o" in "onTriggerEnter"
    {
        objectToActivate.GetComponent<MoveObject10>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true;
        // Changed both MoveObjects to Moveobject10
    }
    private void OnTriggerExit(Collider other)
     //Capitalized "o" in "onTriggerExit"
    {
        objectToActivate.GetComponent<MoveObject10>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true;
        // Changed both MoveObjects to Moveobject10
    }
}
