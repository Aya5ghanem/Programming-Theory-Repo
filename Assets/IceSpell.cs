using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void Cast()
    {
        Debug.Log("Casting Ice Spell ❄");
    }

    public override void Move()
    {
        transform.Translate(Vector3.forward * 5f * Time.deltaTime);
    }

    private void Update()
    {
        Move();
    }
}
