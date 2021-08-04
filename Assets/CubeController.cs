using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
      
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="Cube" || other.gameObject.CompareTag("Plane"))
        {
            GetComponent<AudioSource>().Play();
         
        }
        else
        {
            GetComponent<AudioSource>().volume = 0f;
        }
    }
}
