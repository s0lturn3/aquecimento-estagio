namespace SisNDragons.Models
{
    public class BestiarioRecord
    {

        public int Id { get; set; }
        
        public required string Nome { get; set; }
        
        public string? Descricao { get; set; }
        
        public required int HP { get; set; }

        public required int Nivel { get; set; }

        public required NivelPerigo NivelPerigo { get; set; }

        public required Raridade Raridade { get; set; }

        public required int Dano { get; set; }

        public required int Defesa { get; set; }

        public DateTime? DtRegistro { get; set; }

        public required Tipo Tipo { get; set; }


        public BestiarioRecord()
        {
            Id = 0;
            Nome = "";
            Descricao = null;
            HP = 1;
            Nivel = 1;
            NivelPerigo = NivelPerigo.NENHUM;
            Raridade = Raridade.COMUM;
            Dano = 1;
            Defesa = 1;
            DtRegistro = DateTime.Now;
            Tipo = Tipo.HUMANO;
        }

    }

    public enum NivelPerigo
    {
        NENHUM = 0,
        BAIXO = 1,
        MEDIO = 2,
        ALTO = 3,
        EXTREMO = 4,
        FUJA = 5
    }

    public enum Raridade
    {
        COMUM = 1,
        INCOMUM = 2,
        RARO = 3,
        LENDARIO = 4,
        ICONICO = 5
    }

    public enum Tipo
    {
        HUMANO = 1,
        MORTO_VIVO = 2,
        SELVAGEM = 3,
        GIGANTE = 4,
        ABERRACAO = 5,
        INSETO = 6,
        CONSTRUTO = 7
    }
}
