using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeam
    {
        public string? DevTeamName { get; set; }
       public int? DevTeamId { get; set; }
       public List<Developer>? DevTeamMembers { get; set; }

        public DevTeam() { }

        public DevTeam(string devTeamName, int devTeamId, List<Developer> devTeamMembers)
        {
            DevTeamName = devTeamName;
            DevTeamId = devTeamId;
            //DevTeamMemberId = devTeamMemberId;
            DevTeamMembers = devTeamMembers;
        }
    }

}
