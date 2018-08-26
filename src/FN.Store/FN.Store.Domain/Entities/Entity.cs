using System;

namespace FN.Store.Domain.Entities
{
    public class Entity
    {
        public Entity()
        {
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
