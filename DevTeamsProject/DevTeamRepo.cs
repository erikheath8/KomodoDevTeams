using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTeamsProject;

namespace DevTeamsProject
{
    public class DevTeamRepo
    {
        private List<DevTeam> _devTeams = new List<DevTeam>();

        //DevTeam Create
        public bool AddDevTeamToList(DevTeam devTeam)
        {
            int initialTeamCount = _devTeams.Count();
            _devTeams.Add(devTeam);

            if (_devTeams.Count() > initialTeamCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DevTeam Read
        public List<DevTeam> GetDevTeams()
        {
            return _devTeams;

        }

        //DevTeam Update
        public bool UpdateDevTeams(DevTeam oldTeam, DevTeam  newTeam)
        {
            if (oldTeam != null)
           {
                oldTeam.DevTeamName = newTeam.DevTeamName;
                oldTeam.DevTeamId = newTeam.DevTeamId;
                oldTeam.DevTeamMembers = newTeam.DevTeamMembers;
                return true;
            }
            else
            {
                return false;
            }
        }

        //DevTeam Delete
        public bool RemoveDevTeamFromList(int devTeamId) {

            DevTeam removeDevTeamId = GetDevTeamId(devTeamId);

            int initialDevTeamCount = _devTeams.Count;
            _devTeams.Remove(removeDevTeamId);

            if(initialDevTeamCount > _devTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        //DevTeam Helper (Get Team by ID)
        public DevTeam GetDevTeamId(int getDevId)
        {
            foreach (DevTeam devTeam in _devTeams)
            {
                if (devTeam.DevTeamId == getDevId)
                {
                    return devTeam;
                }
                
            }

            return null;
        }

        public bool AddDevTeamMember(int developerAddToTeam)
        {
            DevTeam newDevId = GetDevTeamId(developerAddToTeam);

            int initialTeamCount = _devTeams.Count();
            _devTeams.Add(newDevId);

            if(_devTeams.Count > initialTeamCount)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }

    }
}
