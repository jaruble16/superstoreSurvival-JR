using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;

public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlatformerCharacter2D>())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SoundManager.Instance.PlayHazardSound();
        }
<<<<<<< Updated upstream:SS Survival Early Demo/Assets/Hazards/Scripts/Hazard.cs
=======

>>>>>>> Stashed changes:SS Survival Early Demo/Assets/MyStuff/Hazards/Scripts/Hazard.cs
    }
}
