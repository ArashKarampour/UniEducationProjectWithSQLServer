using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;
using UniEdu.Entities;

namespace UniEdu.BLL
{
    public class InstructManager
    {
        public Instruct LoadFirstInstruct()
        {
            InstructDao instructdao = new InstructDao();
            return instructdao.LoadFirstInstruct();
        }

        public Instruct LoadNextInstruct(int currentID)
        {
            InstructDao instructdao = new InstructDao();
            return instructdao.LoadNextInstruct(currentID);
        }

        public Instruct LoadPreviousInstruct(int currentID)
        {
            InstructDao instructdao = new InstructDao();
            return instructdao.LoadPreviousInstruct(currentID);
        }

        public Instruct LoadLastInstruct()
        {
            InstructDao instructdao = new InstructDao();
            return instructdao.LoadLastInstruct();
        }

        public Instruct SearchInstruct(int currentID)
        {
            InstructDao instructdao = new InstructDao();
            return instructdao.SearchInstruct(currentID);
        }

        public void UpdateInstruct(Instruct instruct)
        {
            InstructDao instructdao = new InstructDao();
            instructdao.UpdateInstruct(instruct);
        }

        public void AddInstruct(Instruct instruct)
        {
            InstructDao instructdao = new InstructDao();
            instructdao.AddInstruct(instruct);
        }

        public void DeleteInstruct(int currentID)
        {
            InstructDao instructdao = new InstructDao();
            instructdao.DeleteInstruct(currentID);
        }
    }
}
