using ApplicationServices;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApplication.Services
{
    public class HumanServices
    {
        private readonly HumanRepository _humanRepository = new HumanRepository();

        public DomainModel.Human GetById (int id)
        {
            var h1 = _humanRepository.GetById(id);

            return h1.ToDomain();
        }

        public ICollection<DomainModel.Human> GetAll ()
        {
            var humanList = new List<SQLModel.Human>()
            {
                //new SQLModel.Human { Email = "some@email", Id = 1, Name = "Name1" },
                //new SQLModel.Human { Email = "some@email", Id = 2, Name = "Name2" },
                //new SQLModel.Human { Email = "some@email", Id = 3, Name = "Name3" }
        };
            return humanList.ToDomain();
        }
    }
}
