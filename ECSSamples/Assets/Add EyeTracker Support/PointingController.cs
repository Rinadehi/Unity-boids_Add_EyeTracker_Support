using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Tobii.Gaming;

namespace Assets
{
    public class PointingController : MonoBehaviour
    {
        public GameObject ground;
       // Vector2 filteredPoint;

        public void Start()
        {
        
        }

        public void Update()
        {
            Vector2 gazePoint = TobiiAPI.GetGazePoint().Screen;
            //filteredPoint = Vector2.Lerp(filteredPoint, gazePoint, 0.5f);

            //Vector3 screenPoint= Input.mousePosition;
            Vector3 screenPoint = gazePoint;
            screenPoint.z = 1;

            Ray ray = Camera.main.ScreenPointToRay(screenPoint);
            RaycastHit hit;
            Vector3 targetPosition = Vector3.zero;

            if (ground.GetComponent<Collider>().Raycast(ray, out hit, 500))
            {
                targetPosition = hit.point;

                this.gameObject.transform.position = 
                    /**
                    new Vector3(targetPosition.x,
                                this.transform.position.y,
                                targetPosition.z); **/
                    new Vector3(targetPosition.x,
                                targetPosition.y,
                                targetPosition.z);
            }
        }
    }
}
