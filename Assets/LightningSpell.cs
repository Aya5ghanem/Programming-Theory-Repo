using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSpell : Spell
{

    public override void Cast()
    {
        Debug.Log("Casting Lightning ⚡");
    }

    public override void Move()
    {
        transform.Translate(Vector3.forward * 20f * Time.deltaTime);
    }

    private void Update()
    {
        Move();
    }
}
