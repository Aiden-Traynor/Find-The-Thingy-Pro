using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTheThingyMoveScript : MonoBehaviour
{
  public float Speed;
  public float RotationSpeed;
  Rigidbody R;
  public float JumpHeight;
    // Start is called before the first frame update
    void Start()
    {

      Speed = 8f;
      RotationSpeed = 130f;
      R = GetComponent<Rigidbody>();
      JumpHeight = 1f;

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.UpArrow)){
          //move forward line
          R.MovePosition(transform.position + transform.forward * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            //move back line
            R.MovePosition(transform.position - transform.forward * Speed * Time.deltaTime);
          }
      if (Input.GetKey(KeyCode.LeftArrow)) {
          //rotate left line
          transform.Rotate(-Vector3.up * RotationSpeed * Time.deltaTime); /* note the minus sign */
      }
      else if (Input.GetKey(KeyCode.RightArrow)) {
          //rotate right line
          transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space)){
            //move forward line
            R.MovePosition(transform.position + transform.up * JumpHeight );


            // if (Input.GetKey(KeyCode.UpArrow)){
            //     //move forward line
            //     R.MovePosition(transform.position + transform.forward * Speed * Time.deltaTime);
            //   }
            //   else if (Input.GetKey(KeyCode.DownArrow)) {
            //       //move back line
            //       R.MovePosition(transform.position - transform.forward * Speed * Time.deltaTime);
            //     }
            // if (Input.GetKey(KeyCode.LeftArrow)) {
            //     //rotate left line
            //     transform.Rotate(-Vector3.up * RotationSpeed * Time.deltaTime); /* note the minus sign */
            // }
            // else if (Input.GetKey(KeyCode.RightArrow)) {
            //     //rotate right line
            //     transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
            //   }

        }
    }
 }
