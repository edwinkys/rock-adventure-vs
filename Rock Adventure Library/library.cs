using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Adventure
{
    public class library
    {
        // Create skill class
        class skill
        {
            public string description = "You can choose the skill to perform the action of the skill.";
        }

        // Inherit skill class
        class teleportation : skill
        {
            public string skill_description = "Instantly move you to a certain location.";
        }

        // Inherit skill class
        class ultra_laser : skill
        {
            public string skill_description = "Shoot a beam of light at a target.";
        }

        // Inherit skill class
        class invisibility : skill
        {
            public string skill_description = "Become unseen for a period of time.";
        }
    }
}
