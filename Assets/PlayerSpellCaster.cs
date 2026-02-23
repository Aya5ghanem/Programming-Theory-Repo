using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpellCaster : MonoBehaviour
{
    [SerializeField] private GameObject fireSpellPrefab;
    [SerializeField] private GameObject iceSpellPrefab;
    [SerializeField] private GameObject lightningSpellPrefab;
    [SerializeField] private Transform spawnPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            CastSpell(fireSpellPrefab);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            CastSpell(iceSpellPrefab);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            CastSpell(lightningSpellPrefab);
    }

    void CastSpell(GameObject spellPrefab)
    {
        Instantiate(spellPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
