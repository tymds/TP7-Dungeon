using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boolet : MonoBehaviour
{
    private Speciality speciality;


    public void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    private IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(speciality.lifeTime);
        Destroy(this.gameObject);
    }
}
