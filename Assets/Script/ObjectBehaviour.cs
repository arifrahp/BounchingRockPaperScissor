using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    public float speed;
    public GameObject thisObject;
    public enum ObjectType
    {
        rock,
        paper,
        scissor
    };
    [SerializeField] ObjectType objectType = new ObjectType();

    public Collider wall1;
    public Collider wall2;
    public Collider wall3;
    public Collider wall4;
    public Collider scissor;
    public Collider rock;
    public Collider paper;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomY = Random.Range(0f, 360f);
        thisObject.transform.localRotation = Quaternion.Euler(0, randomY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == wall1)
        {
            float randomY = Random.Range(90f, -90f);
            thisObject.transform.localRotation = Quaternion.Euler(0, randomY, 0);
        }
        if (other == wall2)
        {
            float randomY = Random.Range(90f, 270f);
            thisObject.transform.localRotation = Quaternion.Euler(0, randomY, 0);
        }
        if (other == wall3)
        {
            float randomY = Random.Range(180f, 360f); 
            thisObject.transform.localRotation = Quaternion.Euler(0, randomY, 0);
        }
        if (other == wall4)
        {
            float randomY = Random.Range(0f, 180f);
            thisObject.transform.localRotation = Quaternion.Euler(0, randomY, 0);
        }
    }
}
