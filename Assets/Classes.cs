using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "classe", menuName = "Classes", order = 0)]
public class Speciality : ScriptableObject

{
    [field: SerializeField]
    public string Classname {  get; private set; }

    [field: SerializeField]
    public string description { get; private set; }

    [field:SerializeField]
    public float speed { get; private set; }

    [field:SerializeField]
    public GameObject projectile { get; private set; }

    [field:SerializeField]
    public int lifeTime { get; private set; }

    [field:SerializeField]
    public float fireRate { get; private set; }

}
