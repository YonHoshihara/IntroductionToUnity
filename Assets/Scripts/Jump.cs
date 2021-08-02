using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Jump : MonoBehaviour
{

    [SerializeField]
    private float m_JumpForce;
    private Rigidbody2D m_RigdyBody;
    private Vector2 m_JumpVector;
    
    void Start()
    {
        m_RigdyBody = gameObject.GetComponent<Rigidbody2D>();
        m_JumpVector = new Vector2(0, m_JumpForce);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_RigdyBody.AddForce(m_JumpVector, ForceMode2D.Force);
        }
    }
}
