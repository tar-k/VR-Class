using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject game;
    GameObject newInstantiated;
    //public Transform newPos;
    public Transform PosA;
    public Transform PosB;
    public float movingSpeed=1;
    //public Vector3 rotatingSpeed;
    public float rotatingSpeed=10;
    void Start()
    {
        newInstantiated = Instantiate(game, PosA.position, PosA.rotation);        
        //transform.position += new Vector3(1, 0, 0);
        
        //transform.localScale = newPos.localScale;
        //gameObject.SetActive(false);
        //this.enabled = false;
        
        //Destroy(newInstantiated, 3);
    }
    
    private void OnEnable()
    {
        
    }

    private void OnDisable() {
        Destroy(newInstantiated);
    }
    void Update()
    {
        //newInstantiated.transform.position += (newInstantiated.transform.forward * Time.deltaTime * movingSpeed);
        //newInstantiated.transform.eulerAngles += new Vector3(0, 0, 1) * Time.deltaTime * rotatingSpeed;

        //newInstantiated.transform.Rotate(Time.deltaTime*rotatingSpeed);

        newInstantiated.transform.position = Vector3.MoveTowards(newInstantiated.transform.position, PosB.position, movingSpeed*Time.deltaTime); //(что перемещать, куда, скорость)
        newInstantiated.transform.rotation = Quaternion.RotateTowards(newInstantiated.transform.rotation, PosB.rotation, rotatingSpeed*Time.deltaTime);
        
    }
}
