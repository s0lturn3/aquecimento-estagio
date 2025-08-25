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

        /// <summary>
        /// Propriedade privada que armazenará todos os registros fixos.
        /// </summary>
        private readonly List<BestiarioRecord> _criaturas;

        #endregion Private Properties

        #region Private Methods
        
        /// <summary>
        /// Responsável pelas validações de dados nos métodos de Create e Update.
        /// </summary>
        /// <param name="record">Objeto com as informações vindas do Swagger/Postman</param>
        /// <param name="isUpdate">Informa se estou chamado o método para Create ou Update pois algumas validações só fazem sentido para um ou para outro</param>
        /// <exception cref="Exception">Exceções que serão jogadas caso algum dos parâmetros estiver inválido</exception>
        private void ValidateParams(BestiarioRecord record, bool isUpdate)
        {
            if (record == null) throw new Exception("Dados inválidos.");

            if (record.Nome == null) throw new ArgumentException("O campo 'Nome' é obrigatório.");
            if (record.Nivel <= 0) throw new ArgumentException("O campo 'Nível' é obrigatório e não pode ser menor que zero.");
            if (record.Dano < 0) throw new ArgumentException("O campo 'Dano' é obrigatório e não pode ser menor que zero.");
            if (record.Defesa < 0) throw new ArgumentException("O campo 'Defesa' é obrigatório e não pode ser menor que zero.");

            if (isUpdate)
            {
                if (record.Id <= 0) throw new ArgumentException("O identificador 'ID' não pode estar vazio/zerado em uma atualização.");
            }
            else
            {
                if (record.DtRegistro == null) throw new ArgumentException("O campo 'Data de registro' é obrigatório.");
                if (record.DtRegistro > DateTime.Now) throw new ArgumentException("O campo 'Data de registro' não pode ser uma data futura.");
            }

            if (!Enum.IsDefined(typeof(NivelPerigo), record.NivelPerigo)) throw new ArgumentException("Nível de Perigo inválido.");
            if (!Enum.IsDefined(typeof(Raridade), record.Raridade)) throw new ArgumentException("Raridade inválida.");
            if (!Enum.IsDefined(typeof(Tipo), record.Tipo)) throw new ArgumentException("Tipo de criatura inválido.");
        }

        /// <summary>
        /// Puxa o maior ID cadastrado na lista
        /// </summary>
        /// <returns>ID mais alto encontrado na lista.</returns>
        private int GetHighestID()
        {
            BestiarioRecord? record = _criaturas.MaxBy(e => e.Id);
            return record != null ? record.Id : 0;
        }

        #endregion Private Methods

        #region Public Methods

        /// <summary>
        /// Este método retornará a lista de registros completa sem filtragem
        /// </summary>
        /// <returns>Estrutura <see cref="List{T}"/> com todos os registros</returns>
        public List<BestiarioRecord> GetList()
        {
            try
            {
                return _criaturas;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Busca um registro único com base no ID informado
        /// </summary>
        /// <param name="id">ID a ser pesquisado</param>
        /// <returns>Registro do tipo <see cref="BestiarioRecord"/></returns>
        public BestiarioRecord Get(int id)
        {
            try
            {
                var record = _criaturas.FirstOrDefault(e => e.Id == id);

                if (record == null) throw new KeyNotFoundException("Nenhum registro encontrado com este ID.");
                return record;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Filtra a lista de criaturas com base em diversos campos opcionais
        /// </summary>
        /// <param name="nome">Nome da criatura</param>
        /// <param name="nivel">Nível da criatura</param>
        /// <param name="tipo">Tipo da criatura</param>
        /// <param name="nivelPerigo">Nível de perigo</param>
        /// <param name="raridade">Raridade</param>
        /// <returns>Estrutura <see cref="List{T}"/> com todos os registros filtrados ou uma exeção caso não encontre nenhum registro.</returns>
        public List<BestiarioRecord> GetFilter(string? nome, int? nivel, int? tipo, int? nivelPerigo, int? raridade)
        {
            try
            {
                var records = _criaturas.Where(e => nome != null ? e.Nome.Contains(nome) : true)
                                        .Where(e => nivel != null ? e.Nivel == nivel : true)
                                        .Where(e => tipo != null ? e.Tipo == (Tipo)tipo : true)
                                        .Where(e => nivelPerigo != null ? e.NivelPerigo == (NivelPerigo)nivelPerigo : true)
                                        .Where(e => raridade != null ? e.Raridade == (Raridade)raridade : true);

                if (records == null || records.Count() == 0) throw new ArgumentException("Nenhum registro encontrado com esta filtragem.");
                return records.ToList();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Cria um registro de criatura na lista já existente.
        /// </summary>
        /// <param name="record">Registro preenchido</param>
        public void Create(BestiarioRecord record)
        {
            try
            {
                ValidateParams(record, false);

                if (record.Id == 0) record.Id = GetHighestID() + 1;

                bool alreadyHasID = _criaturas.FindAll(e => e.Id == record.Id).Count > 0;
                if (alreadyHasID) throw new ArgumentException("O ID informado já existe na lista, informe outro.");

                _criaturas.Add(record);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Atualiza um registro já existente com base no ID encontrado
        /// </summary>
        /// <param name="record">Registro preenchido</param>
        public void Update(BestiarioRecord record)
        {
            try
            {
                ValidateParams(record, true);

                int foundIndex = _criaturas.FindIndex(e => e.Id == record.Id);
                if (foundIndex == -1) throw new KeyNotFoundException("Registro não encontrado com este ID.");

                var originalRecord = _criaturas[foundIndex];

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
                    Tipo = record.Tipo,

                    DtRegistro = originalRecord.DtRegistro  // Preserva a data de registro já existente
                };
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// Exclui um registro
        /// </summary>
        /// <param name="id">ID a ser excluído</param>
        public void Delete(int id)
        {
            try
            {
                int foundIndex = _criaturas.FindIndex(e => e.Id == id);
                if (foundIndex == -1) throw new KeyNotFoundException("Nenhum registro encontrado com este ID.");

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
