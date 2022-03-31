using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    public float move_speed;
    [SerializeField]
    public float leftRightSpeed;
    public float speed, ziplama;

    public GameObject character;


    [SerializeField] private Animator m_animator = null;
    [SerializeField] private Rigidbody m_rigidBody = null;
    public Rigidbody rb;
   
    void Start()
    {
        
        rb.GetComponent<Rigidbody>();
         character.GetComponent<Transform>();
    }
    private void Awake()
    {
        if (!m_animator) { gameObject.GetComponent<Animator>(); }
        if (!m_rigidBody) { gameObject.GetComponent<Animator>(); }
    }

   
    void Update()
    {
        Move1();
        
       
    }

    void Move1()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * leftRightSpeed * Time.deltaTime;
        this.transform.Translate(yatayEksen, 0, move_speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space)) {
           if(character.transform.localPosition.y > 0 && character.transform.localPosition.y < 3)
                rb.AddForce(Vector3.up * ziplama);
        }
       
    }    
    
}
