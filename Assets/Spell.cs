using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    [SerializeField] protected float damage = 10f;

    public abstract void Cast();

    public virtual void Move()
    {
        transform.Translate(Vector3.forward * 10f * Time.deltaTime);
    }
}
