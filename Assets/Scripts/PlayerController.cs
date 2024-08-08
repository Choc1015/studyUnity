using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10f;

    void Start()
    {
        Managers.Input.KeyAction -= Onkeyboard;
        Managers.Input.KeyAction += Onkeyboard;
    }

    
    void Update()
    {
        
    }

    public void Onkeyboard()
    {


        // 절대 회전값
        //transform.eulerAngles = new Vector3(0, _yAnlge, 0);

        // +- delta
        //transform.Rotate(new Vector3(0, _yAnlge, 0));

        //transform.rotation = Quaternion.Euler(new Vector3(0, _yAnlge, 0)); 

        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}
