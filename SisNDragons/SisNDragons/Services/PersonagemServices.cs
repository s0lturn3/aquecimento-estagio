using SisNDragons.Models;

namespace SisNDragons.Services
{
    public class PersonagemServices
    {
        public PersonagemServices()
        {
            _personagens = new List<PersonagemRecord>
            {
                new PersonagemRecord {
                    Id = 1,
                    Nome = "Erick Dot'Netus",
                    Vida = 10,
                    Nivel = 1,
                    Xp = 0,
                    Raca = Raca.Serafim,
                    Alinhamento = Alinhamento.Caotico_Bom,
                    Classe = new ClasseRecord
                    {
                        Nome = "Guerreiro C'Sharpness",
                        Descricao = "Um combatente versátil que domina tanto o campo de batalha quanto a lógica dos códigos. Forjado em linhas de comando e treinado em batalhas contra bugs lendários, o Guerreiro C# canaliza sua força através de estruturas sólidas e ataques precisos.",
                        Habilidades = new List<string>
                        {
                            "Golpe de Sintaxe Afiada",
                            "Escudo da Tipagem Forte",
                            "Combo Assíncrono Devastador",
                            "Refatorar Estratégia",
                            "Compilação Impecável",
                            "Ataque Genérico",
                            "Sobrecarga de Métodos",
                            "Lâmina LINQ Relâmpago"
                        }
                    },
                    Subclasse = new SubclasseRecord
                    {
                        Nome = "Paladino do Debug",
                        Descricao = "O Paladino do Debug é um guerreiro sagrado do código, dedicado a caçar e eliminar bugs onde quer que eles surjam. Armado com o Martelo da Validação e protegido pelo Escudo da Integridade, ele é capaz de purgar falhas críticas e manter a estabilidade de toda a equipe. Sua presença inspira aliados e desestabiliza inimigos, garantindo que cada execução seja perfeita.",

                        Habilidades = new List<string>
                        {
                            "Martelo da Validação",
                            "Escudo da Integridade",
                            "Purga de Bugs",
                            "Refatoração Sagrada",
                            "Depuração Relâmpago",
                            "Log da Vitória"
                        }
                    },
                    Atributos = new AtributoRecord(),
                    Is_Dead = false
                },
                new PersonagemRecord {
                    Id = 1,
                    Nome = "Matheus Angularius",
                    Vida = 10,
                    Nivel = 1,
                    Xp = 0,
                    Raca = Raca.Serafim,
                    Alinhamento = Alinhamento.Caotico_Bom,
                    Classe = new ClasseRecord
                    {
                        Nome = "Arquiteto Angular",
                        Descricao = "Um mestre da construção de interfaces e fluxos de poder, o Arquiteto Angular ergue estruturas sólidas e escaláveis a partir de componentes modulares. Seu conhecimento de diretivas e bindings o torna capaz de manipular a realidade da tela com fluidez, transformando dados em visão pura.",
                        Habilidades = new List<string>
                        {
                            "Componente Vivo",
                            "Data Binding Duplo",
                            "Diretiva Protetora",
                            "Injeção de Dependência",
                            "Roteamento Dimensional"
                        }
                    },
                    Subclasse = new SubclasseRecord
                    {
                        Nome = "Guardião de Rotas",
                        Descricao = "Especializado em controle de caminhos e proteção, o Guardião de Rotas é aquele que decide quem pode ou não avançar. Suas habilidades impedem a passagem de inimigos e garantem que o fluxo do combate siga da forma mais segura para sua equipe.",

                        Habilidades = new List<string>
                        {
                            "Bloqueio de Rotas",
                            "Autenticação de Aliados",
                            "Redirecionamento Estratégico",
                            "Cache de Energia",
                            "Lazy Loading"
                        }
                    },
                    Atributos = new AtributoRecord(),
                    Is_Dead = false
                },
            };
        }

        #region Private Properties

        private List<PersonagemRecord> _personagens;

        #endregion Private Properties

        #region Private Methods

        #endregion Private Methods

        #region Public Methods

        public List<PersonagemRecord> GetList()
        {
            try
            {
                return _personagens;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public PersonagemRecord Get(int id)
        {
            try
            {
                var record = _personagens.FirstOrDefault(e => e.Id == id);

                if (record == null) throw new Exception("Nenhum registro encontrado com este ID.");
                return record;
            }
            catch
            {
                throw;
            }
        }

        public int GetVida(int id)
        {
            try
            {
                var record = _personagens.FirstOrDefault(e => e.Id == id);

                if (record == null) throw new Exception("Nenhum registro encontrado com este ID.");

                int vida = record.Vida + (record.Vida_Extra ?? 0);
                return vida;
            }
            catch
            {
                throw;
            }
        }

        public List<PersonagemRecord> GetFilter(string? nome, int? raca, int? nivel, string? classe, int? alinhamento, bool? is_dead)
        {
            try
            {
                var records = _personagens.Where(e => nome != null ? e.Nome.Contains(nome) : true)
                                        .Where(e => nivel != null ? e.Nivel == nivel : true)
                                        .Where(e => raca != null ? e.Raca == (Raca)raca : true)
                                        .Where(e => classe != null ? e.Classe.Nome.Contains(classe) : true)
                                        .Where(e => is_dead != null ? e.Is_Dead == is_dead : true)
                                        .Where(e => alinhamento != null ? e.Alinhamento == (Alinhamento)alinhamento : true);

                if (records == null || records.Count() == 0) throw new Exception("Nenhum registro encontrado com esta filtragem.");
                return records.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void Create(PersonagemRecord record)
        {
            try
            {
                if (record == null) throw new Exception("");
                _personagens.Add(record);
            }
            catch
            {
                throw;
            }
        }

        public void Update(PersonagemRecord record)
        {
            try
            {
                int foundIndex = _personagens.FindIndex(e => e.Id == record.Id);
                if (foundIndex == -1) throw new Exception("Personagem não encontrado");

                _personagens[foundIndex] = new PersonagemRecord
                {
                    Id = record.Id,
                    Nome = record.Nome,
                    Raca = record.Raca,
                    Vida = record.Vida,
                    Vida_Extra = record.Vida_Extra,
                    Nivel = record.Nivel,
                    Xp = record.Xp,
                    Alinhamento = record.Alinhamento,
                    Classe = record.Classe,
                    Subclasse = record.Subclasse,
                    Atributos = record.Atributos,
                    Is_Dead = record.Is_Dead
                };
            }
            catch
            {
                throw;
            }
        }

        public void PatchVida(int id, int vida, int vidaExtra)
        {
            try
            {
                int foundIndex = _personagens.FindIndex(e => e.Id == id);
                if (foundIndex == -1) throw new Exception("Personagem não encontrado");

                _personagens[foundIndex].Vida = vida;
                _personagens[foundIndex].Vida_Extra = vidaExtra;
            }
            catch
            {
                throw;
            }
        }

        public void PatchAtributos(int id, AtributoRecord atributos)
        {
            try
            {
                int foundIndex = _personagens.FindIndex(e => e.Id == id);
                if (foundIndex == -1) throw new Exception("Personagem não encontrado");

                _personagens[foundIndex].Atributos = atributos;
            }
            catch
            {
                throw;
            }
        }

        public void PatchClasse(int id, PatchClasseRecord record)
        {
            try
            {
                int foundIndex = _personagens.FindIndex(e => e.Id == id);
                if (foundIndex == -1) throw new Exception("Personagem não encontrado");

                _personagens[foundIndex].Classe = record.Classe;
                _personagens[foundIndex].Subclasse = record.Subclasse;
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
                int foundIndex = _personagens.FindIndex(e => e.Id == id);
                if (foundIndex == -1) throw new Exception("Nenhum registro encontrado com este ID.");

                _personagens.RemoveAt(foundIndex);
            }
            catch
            {
                throw;
            }
        }

        #endregion Public Methods

    }
}
