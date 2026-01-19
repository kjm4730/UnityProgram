using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering;
using System.Threading;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] List<Weapon> weapons;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }

        if(Input.GetMouseButtonDown(0))
        {
            weapons[count].Attack();
        }
    }

    public void Swap()
    {
        weapons[count].gameObject.SetActive(false);

        count = (count + 1) % weapons.Count;

        weapons[count].gameObject.SetActive(true);
    }


}
