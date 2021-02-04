using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTheThingyMoveScript : MonoBehaviour
{
  public float Speed;
  public float RotationSpeed;
  Rigidbody R;
  public float JumpHeight;
  bool jumping = false;
  Animator AV;
    // Start is called before the first frame update
    void Start()
    {

      Speed = 8f;
      AV = GetComponent<Animator>();
      RotationSpeed = 130f;
      R = GetComponent<Rigidbody>();
      JumpHeight = 400f;


    }

    // Update is called once per frame
    void Update()
    {


      if (Input.GetKey(KeyCode.UpArrow)){
          //move forward line
          R.MovePosition(transform.position + transform.forward * Speed * Time.deltaTime);
          AV.SetBool("Walk", true);

        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            //move back line
            R.MovePosition(transform.position - transform.forward * Speed * Time.deltaTime);
            AV.SetBool("Walk", true);
          }
          else {
AV.SetBool("Walk", false);
}

      if (Input.GetKey(KeyCode.LeftArrow)) {
          //rotate left line
          transform.Rotate(-Vector3.up * RotationSpeed * Time.deltaTime); /* note the minus sign */
      }
      else if (Input.GetKey(KeyCode.RightArrow)) {
          //rotate right line
          transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }
        if (!jumping && Input.GetKey(KeyCode.Space)){
            //move forward line
            R.AddForce( Vector3.up * JumpHeight );
	jumping = true;



        }
    }
void OnCollisionEnter(Collision other)
{
		if(other.collider.tag.Equals("Ground")) //if we hit the floor, we are no longer jumping
{
	jumping = false;
		}
	}
 }
