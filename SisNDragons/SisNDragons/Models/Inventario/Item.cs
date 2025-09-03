namespace SisNDragons.Models.Inventario
{
    public class Item
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string TipoId { get; set; }

        public bool IsEquipavel { get; set; }

        public bool IsConsumivel { get; set; }

        public int Dano { get; set; }

        public int Defesa { get; set; }


        public Item()
        {
            Id = 0;
            Nome = string.Empty;
            Descricao = string.Empty;
            TipoId = string.Empty;
            IsEquipavel = false;
            IsConsumivel = false;
            Dano = 0;
            Defesa = 0;
        }
    }
}
