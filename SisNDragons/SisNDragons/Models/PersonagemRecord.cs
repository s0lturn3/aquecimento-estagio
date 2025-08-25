namespace SisNDragons.Models
{
    public class PersonagemRecord
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required Raca Raca { get; set; }

        public required int Vida { get; set; }

        public int? Vida_Extra { get; set; }

        public required int Nivel { get; set; }

        public required int Xp { get; set; }

        public required Alinhamento Alinhamento { get; set; }

        public ClasseRecord Classe { get; set; }

        public SubclasseRecord Subclasse { get; set; }

        public AtributoRecord Atributos { get; set; }

        public required bool Is_Dead { get; set; }

        public PersonagemRecord()
        {
            Id = 0;
            Nome = "";
            Raca = 0;
            Vida = 10;
            Vida_Extra = null;
            Nivel = 1;
            Xp = 0;
            Alinhamento = Alinhamento.Neutro;
            Classe = new ClasseRecord();
            Subclasse = new SubclasseRecord();
            Atributos = new AtributoRecord();
            Is_Dead = false;
        }
    }

    public enum Raca
    {
        Desconhecido = 0,
        Dracônico = 1,
        Elfo = 2,
        Aracnideo = 3,
        Serafim = 4,
        Humano = 5,
        Estelar = 6
    }

    public enum Alinhamento
    {
        Leal_Bom = 1,
        Leal_Neutro = 2,
        Leal_Mau = 3,
        Neutro_Bom = 4,
        Neutro = 5,
        Neutro_Mau = 6,
        Caotico_Bom = 7,
        Caotico_Neutro = 8,
        Caotico_Mau = 9
    }

    public class AtributoRecord
    {
        public int forca { get; set; }

        public int destreza { get; set; }

        public int constituicao { get; set; }

        public int inteligencia { get; set; }

        public int sabedoria { get; set; }

        public int carisma { get; set; }

        public AtributoRecord()
        {
            this.forca = 1;
            this.destreza = 1;
            this.constituicao = 1;
            this.inteligencia = 1;
            this.sabedoria = 1;
            this.carisma = 1;
        }
    }

    public class  ClasseRecord
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public List<string> Habilidades { get; set; }

        public ClasseRecord()
        {
            this.Nome = "Desconhecido";
            this.Descricao = "";
            this.Habilidades = new List<string>();
        }
    }

    public class SubclasseRecord
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public List<string> Habilidades { get; set; }

        public SubclasseRecord()
        {
            this.Nome = "Desconhecido";
            this.Descricao = "";
            this.Habilidades = new List<string>();
        }
    }
}
