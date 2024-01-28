using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;
using UniEdu.Entities;

namespace UniEdu.BLL
{
    public class PresentManager
    {
        public Present LoadFirstPresent()
        {
            PresentDao presentdao = new PresentDao();
            return presentdao.LoadFirstPresent();
        }

        public Present LoadNextPresent(int currentID)
        {
            PresentDao presentdao = new PresentDao();
            return presentdao.LoadNextPresent(currentID);
        }

        public Present LoadPreviousPresent(int currentID)
        {
            PresentDao presentdao = new PresentDao();
            return presentdao.LoadPreviousPresent(currentID);
        }

        public Present LoadLastPresent()
        {
            PresentDao presentdao = new PresentDao();
            return presentdao.LoadLastPresent();
        }

        public Present SearchPresent(int currentID)
        {
            PresentDao presentdao = new PresentDao();
            return presentdao.SearchPresent(currentID);
        }

        public void UpdatePresent(Present present)
        {
            PresentDao presentdao = new PresentDao();
            presentdao.UpdatePresent(present);
        }

        public void AddPresent(Present present)
        {
            PresentDao presentdao = new PresentDao();
            presentdao.AddPresent(present);
        }

        public void DeletePresent(int currentID)
        {
            PresentDao presentdao = new PresentDao();
            presentdao.DeletePresent(currentID);
        }
    }
}
