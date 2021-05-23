using UnityEngine;
using System.Collections;

namespace ShipGame
{
[RequireComponent(typeof(CharacterController))]
    public class PlayerMovement2 : MonoBehaviour
    {
        
        public float speed = 3.0F;
        public float rotateSpeed = 3.0F;
        Vector3 temp;
        private void Start()
        {         
            temp = this.transform.position;
        }
        
            void Update()
            {
            CharacterController controller = GetComponent<CharacterController>();

        
        transform.Rotate(0, Input.GetAxis("Horizontal")*Time.deltaTime * rotateSpeed, 0);

        
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }
}
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//namespace ShipGame
//{
//    public class PlayerMovement2 : MonoBehaviour
//    {
//        public float speed;
//        public float rotationSpeed;
//        // Start is called before the first frame update
//        void Start()
//        {

//        }

//        // Update is called once per frame
//        void Update()
//        {
//            float horizontalInput = Input.GetAxis("Horizontal");
//            float verticalInput = Input.GetAxis("Vertical");

//            Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
//            movementDirection.Normalize();

//            transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

//            if(movementDirection!=Vector3.zero)
//            {
//                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
//                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
//            }
//        }        
//    }
//}
