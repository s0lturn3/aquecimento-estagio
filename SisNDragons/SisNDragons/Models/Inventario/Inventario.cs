namespace SisNDragons.Models.Inventario
{
    public class Inventario
    {
        public int Id { get; set; }

        public string PersonagemId { get; set; }

        public string Descricao { get; set; }

        public List<Item> Itens { get; set; }

        public int Quantidade { get; set; }


        public Inventario()
        {
            Id = 0;
            PersonagemId = string.Empty;
            Descricao = string.Empty;
            Itens = new List<Item>();
            Quantidade = 0;
        }
    }
}
