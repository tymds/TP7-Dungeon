using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Speciality speciality;
    public Rigidbody2D player;


    Vector2 movementAxis;
    Vector2 mousePos;
    

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Vertical");
        float vertical = Input.GetAxisRaw("Horizontal");

        movementAxis = new Vector2 (vertical, horizontal).normalized;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }

    private void FixedUpdate()
    {
        player.velocity = new Vector2(movementAxis.x * speciality.speed, movementAxis.y * speciality.speed);
        Vector2 pointerAim = mousePos - player.position;
        float pointerAng = Mathf.Atan2(pointerAim.y, pointerAim.x) * Mathf.Rad2Deg * 90f;
        player.rotation = pointerAng;



    }
}
