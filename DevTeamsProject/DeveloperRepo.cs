using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
       public List<Developer> _developerDirectory = new List<Developer>();

        //Developer Create
        public bool AddDeveloperToList(Developer developer)
        {
            int intialDevsCount = _developerDirectory.Count();
            _developerDirectory.Add(developer);

            if(_developerDirectory.Count > intialDevsCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Developer Read
        public List<Developer> GetDevelopers()
        {
            return _developerDirectory;
        }

        //Developer Update
        public bool UpdateDevelopers(Developer oldDev, Developer newDev)
        {
            
            // update the content
            if (oldDev != null)
            {
                oldDev.FirstName = newDev.FirstName;
                oldDev.LastName = newDev.LastName;
                oldDev.DevId = newDev.DevId;
                oldDev.HasLicense = newDev.HasLicense;
                return true;

            }
            else
            {
                return false;
            }

        }

        //Developer Delete
        public bool RemoveDeveoperFromList(int devId)
        {
            Developer removeDevId = GetDeveloperId(devId);

            int intialDevIdCount = _developerDirectory.Count;
            _developerDirectory.Remove(removeDevId);

            if(intialDevIdCount > _developerDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Developer Helper (Get Developer by ID)
        public Developer GetDeveloperId(int idNum)
        {
            foreach (Developer developer in _developerDirectory)
            {
                if (developer.DevId == idNum)
                {
                    return developer;
                }
            }

            return null;
        }

        public List<Developer> GetDevoperPlural()
        {
            List<Developer> pluralDevId = new List<Developer>();
            
            foreach (Developer developer in _developerDirectory)
            {                
                if(developer.HasLicense == false)
                {
                    pluralDevId.Add(developer);
                                        
                }
            }
                return pluralDevId;
        }

    }
}
