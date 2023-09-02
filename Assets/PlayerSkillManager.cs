// Author: JOHN LEE
// This will be merged into PlayerController later.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillManager : MonoBehaviour
{
    public int skill1 = 0;
    public int skill2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.skill1 = 0;
        this.skill2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddSkill(int no) // Adding order: skill1 -> skill2 -> The skill which lasts for the least time.
    {
        if (skill1 == 0)
        {
            this.skill1 = no;
        }
        else if (skill2 == 0)
        {
            this.skill2 = no;
        }
    }
}
