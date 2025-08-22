using SisNDragons.Models;

namespace SisNDragons.Services
{
    public class BestiarioServices
    {

        // Construtor da minha services, que inicializa uma lista fixa de criaturas que será acessada pelo Controller e pelos métodos da Service.
        public BestiarioServices()
        {
            _criaturas = new List<BestiarioRecord>
            {
                new BestiarioRecord {
                    Id = 1,
                    Nome = "Goblin Ladino",
                    Descricao = "Pequena criatura verde e astuta, conhecida por suas emboscadas e roubos. Evita combate direto.",
                    HP = 25,
                    Nivel = 3,
                    NivelPerigo = NivelPerigo.BAIXO,
                    Raridade = Raridade.COMUM,
                    Dano = 15,
                    Defesa = 8,
                    DtRegistro = DateTime.Now.AddDays(-45),
                    Tipo = Tipo.HUMANO
                },

                new BestiarioRecord {
                    Id = 2,
                    Nome = "Esqueleto Guerreiro",
                    Descricao = "Restos animados de um antigo soldado. Seus ossos rangem a cada movimento e suas órbitas vazias brilham com luz sinistra.",
                    HP = 40,
                    Nivel = 5,
                    NivelPerigo = NivelPerigo.MEDIO,
                    Raridade = Raridade.INCOMUM,
                    Dano = 22,
                    Defesa = 18,
                    DtRegistro = DateTime.Now.AddDays(-30),
                    Tipo = Tipo.MORTO_VIVO
                },

                new BestiarioRecord {
                    Id = 3,
                    Nome = "Lobo das Sombras",
                    Descricao = "Predador noturno com pelagem negra como a noite. Caça em matilhas e é conhecido por sua velocidade sobrenatural.",
                    HP = 55,
                    Nivel = 6,
                    NivelPerigo = NivelPerigo.MEDIO,
                    Raridade = Raridade.INCOMUM,
                    Dano = 28,
                    Defesa = 12,
                    DtRegistro = DateTime.Now.AddDays(-22),
                    Tipo = Tipo.SELVAGEM
                },

                new BestiarioRecord {
                    Id = 4,
                    Nome = "Golem de Ferro",
                    Descricao = "Construção mágica feita de ferro puro. Criado para proteger tesouros antigos, é extremamente resistente mas lento.",
                    HP = 120,
                    Nivel = 12,
                    NivelPerigo = NivelPerigo.ALTO,
                    Raridade = Raridade.RARO,
                    Dano = 45,
                    Defesa = 35,
                    DtRegistro = DateTime.Now.AddDays(-15),
                    Tipo = Tipo.CONSTRUTO
                },

                new BestiarioRecord {
                    Id = 5,
                    Nome = "Aranha Gigante Venenosa",
                    Descricao = "Aracnídeo do tamanho de um cavalo. Suas presas gotejam veneno mortal e suas teias são fortes como aço.",
                    HP = 65,
                    Nivel = 8,
                    NivelPerigo = NivelPerigo.ALTO,
                    Raridade = Raridade.RARO,
                    Dano = 35,
                    Defesa = 15,
                    DtRegistro = DateTime.Now.AddDays(-12),
                    Tipo = Tipo.INSETO
                },

                new BestiarioRecord {
                    Id = 6,
                    Nome = "Ogro das Montanhas",
                    Descricao = "Gigante brutamontes que vive em cavernas montanhosas. Sua força descomunal pode quebrar rochas com as mãos nuas.",
                    HP = 180,
                    Nivel = 15,
                    NivelPerigo = NivelPerigo.ALTO,
                    Raridade = Raridade.INCOMUM,
                    Dano = 60,
                    Defesa = 25,
                    DtRegistro = DateTime.Now.AddDays(-8),
                    Tipo = Tipo.GIGANTE
                },

                new BestiarioRecord {
                    Id = 7,
                    Nome = "Beholder Ancião",
                    Descricao = "Aberração com múltiplos olhos que disparam raios mágicos mortais. Sua inteligência é tão perigosa quanto seus poderes.",
                    HP = 250,
                    Nivel = 20,
                    NivelPerigo = NivelPerigo.EXTREMO,
                    Raridade = Raridade.LENDARIO,
                    Dano = 85,
                    Defesa = 40,
                    DtRegistro = DateTime.Now.AddDays(-5),
                    Tipo = Tipo.ABERRACAO
                },

                new BestiarioRecord {
                    Id = 8,
                    Nome = "Lich Supremo",
                    Descricao = "Mago morto-vivo de poder incomensurável. Domina magias devastadoras e comanda legiões de mortos-vivos.",
                    HP = 300,
                    Nivel = 25,
                    NivelPerigo = NivelPerigo.FUJA,
                    Raridade = Raridade.ICONICO,
                    Dano = 100,
                    Defesa = 45,
                    DtRegistro = DateTime.Now.AddDays(-3),
                    Tipo = Tipo.MORTO_VIVO
                },

                new BestiarioRecord {
                    Id = 9,
                    Nome = "Camponês Assombrado",
                    Descricao = "Antigo fazendeiro possuído por espíritos malignos. Aparenta ser inofensivo até revelar sua verdadeira natureza.",
                    HP = 35,
                    Nivel = 4,
                    NivelPerigo = NivelPerigo.BAIXO,
                    Raridade = Raridade.COMUM,
                    Dano = 18,
                    Defesa = 10,
                    DtRegistro = DateTime.Now.AddDays(-18),
                    Tipo = Tipo.HUMANO
                },

                new BestiarioRecord {
                    Id = 10,
                    Nome = "Mantícora Alada",
                    Descricao = "Criatura lendária com corpo de leão, asas de morcego e cauda de escorpião. Seus espinhos venenosos podem ser disparados à distância.",
                    HP = 200,
                    Nivel = 18,
                    NivelPerigo = NivelPerigo.EXTREMO,
                    Raridade = Raridade.LENDARIO,
                    Dano = 75,
                    Defesa = 30,
                    DtRegistro = DateTime.Now.AddDays(-1),
                    Tipo = Tipo.SELVAGEM
                }
            };
        }

        #region Private Properties

        private List<BestiarioRecord> _criaturas;

        #endregion Private Properties

        #region Private Methods
        
        /// <summary>
        /// Responsável pelas validações de dados nos métodos de Create e Update.
        /// </summary>
        /// <param name="record">Objeto com as informações vindas do Swagger/Postman</param>
        /// <param name="isUpdate">Informa se estou chamado o método para Create ou Update pois algumas validações só fazem sentido para um ou para outro</param>
        /// <exception cref="Exception"></exception>
        private void ValidateParams(BestiarioRecord record, bool isUpdate)
        {
            if (record == null) throw new Exception("Dados inválidos.");

            if (record.Id <= 0) throw new Exception("O identificador 'ID' não pode estar vazio/zerado.");

            if (record.Nome == null) throw new Exception("O campo 'Nome' é obrigatório.");
            if (record.Nivel <= 0) throw new Exception("O campo 'Nível' é obrigatório e não pode ser menor que zero.");
            if (record.NivelPerigo < 0) throw new Exception("O campo 'Nível de Perigo' é obrigatório.");
            if (record.Raridade <= 0) throw new Exception("O campo 'Raridade' é obrigatório.");
            if (record.Dano < 0) throw new Exception("O campo 'Dano' é obrigatório e não pode ser menor que zero.");
            if (record.Defesa < 0) throw new Exception("O campo 'Dano' é obrigatório e não pode ser menor que zero.");

            if (!isUpdate)
            {
                if (record.DtRegistro == null) throw new Exception("O campo 'Data de registro' é obrigatório.");
                if (record.DtRegistro > DateTime.Now) throw new Exception("O campo 'Data de registro' não pode ser uma data futura.");
            }

            if (record.Tipo < 0) throw new Exception("O campo 'Tipo' é obrigatório.");
        }

        #endregion Private Methods

        #region Public Methods
        
        public List<BestiarioRecord> GetList()
        {
            try
            {
                return _criaturas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public BestiarioRecord Get(int id)
        {
            try
            {
                var record = _criaturas.FirstOrDefault(e => e.Id == id);

                if (record == null) throw new Exception("Nenhum registro encontrado com este ID.");
                return record;
            }
            catch
            {
                throw;
            }
        }

        public List<BestiarioRecord> GetFilter(string? nome, int? nivel, int? tipo, int? nivelPerigo, int? raridade)
        {
            try
            {
                var records = _criaturas.Where(e => nome != null ? e.Nome.Contains(nome) : true)
                                        .Where(e => nivel != null ? e.Nivel == nivel : true)
                                        .Where(e => tipo != null ? e.Tipo == (Tipo)tipo : true)
                                        .Where(e => nivelPerigo != null ? e.NivelPerigo == (NivelPerigo)nivelPerigo : true)
                                        .Where(e => raridade != null ? e.Raridade == (Raridade)raridade : true);

                if (records == null || records.Count() == 0) throw new Exception("Nenhum registro encontrado com esta filtragem.");
                return records.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void Create(BestiarioRecord record)
        {
            try
            {
                ValidateParams(record, false);

                if (record == null) throw new Exception("Dados inválidos!");
                _criaturas.Add(record);
            }
            catch
            {
                throw;
            }
        }

        public void Update(BestiarioRecord record)
        {
            try
            {
                ValidateParams(record, true);

                int foundIndex = _criaturas.FindIndex(e => e.Id == record.Id);
                if (foundIndex == -1) throw new Exception("Registro não encontrado com este ID.");

                _criaturas[foundIndex] = new BestiarioRecord
                {
                    Id = record.Id,
                    Nome = record.Nome,
                    Descricao = record.Descricao,
                    HP = record.HP,
                    Nivel = record.Nivel,
                    NivelPerigo = record.NivelPerigo,
                    Raridade = record.Raridade,
                    Dano = record.Dano,
                    Defesa = record.Defesa,
                    Tipo = record.Tipo
                };
            }
            catch
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                int foundIndex = _criaturas.FindIndex(e => e.Id == id);
                if (foundIndex == -1) throw new Exception("Nenhum registro encontrado com este ID.");

                _criaturas.RemoveAt(foundIndex);
            }
            catch
            {
                throw;
            }
        }

        #endregion Public Methods

    }
}
