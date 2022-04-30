using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float m_speed = 7f;

    // Start is called before the first frame update

    void Update()
    {
        MovePlayer();
    }

    // Update is called once per frame
    private void MovePlayer()
    {
        float x_direction = Input.GetAxis("Horizontal");
        float y_direction = Input.GetAxis("Vertical");

        Vector3 move_dir = new Vector3(x_direction, 0f, y_direction) * m_speed * Time.deltaTime;

        transform.Translate(move_dir, Space.Self);


    }
}