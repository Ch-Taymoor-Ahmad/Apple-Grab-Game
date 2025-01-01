using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
        public float speed = 10f; // Speed of hand movement

        void Update()
        {
            // Get mouse position in world space
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Update the hand's position (lock z to 0 for 2D)
            Vector3 targetPosition = new Vector3(mousePosition.x, mousePosition.y, 0f);

            // Smoothly move the hand to the mouse position
            transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Apple") || other.CompareTag("Coin"))
            {
                GrabItem(other.gameObject);
            }
        }

        private void GrabItem(GameObject item)
        {
            // Destroy the collectible
            Destroy(item);

            // Notify the GameManager to update the score
            FindObjectOfType<GameManager>().AddScore(item.tag);
        }
}
