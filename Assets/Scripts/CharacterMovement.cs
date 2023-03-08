using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    [Header("Movement Attribute")]
    public float speed = 5;
    public float rotAngle = 0;
    public float turnSmoothTime = 0.2f;
    
    float turnnSmoothVelocity;
    
    public MobileInputController m_inpul_Right;

	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () 
    {
        PlayerLookAtUserPointPosition();
    }

    private void PlayerLookAtUserPointPosition()
    {
        Vector3 from = new Vector3(0f, 0f, 1f);
        Vector3 to = new Vector3(m_inpul_Right.Horizontal, 0f, m_inpul_Right.Vertical);

        if (m_inpul_Right.Horizontal != 0 && m_inpul_Right.Vertical != 0)
        {
            float angle = Vector3.SignedAngle(from, to, Vector3.up);
            rotAngle = angle;

            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, angle, ref turnnSmoothVelocity, turnSmoothTime);
        }
    }
}
