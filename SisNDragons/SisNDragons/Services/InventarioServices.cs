using SisNDragons.Models;
using SisNDragons.Models.Inventario;

namespace SisNDragons.Services
{
    public class InventarioServices
    {

        // Construtor da minha services, que inicializa uma lista fixa de criaturas que será acessada pelo Controller e pelos métodos da Service.
        public InventarioServices()
        {
            _inventario = new List<Inventario>();
        }

        #region Private Properties

        /// <summary>
        /// Propriedade privada que armazenará todos os registros fixos.
        /// </summary>
        private readonly List<Inventario> _inventario;

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
            
        }

        /// <summary>
        /// Puxa o maior ID cadastrado na lista
        /// </summary>
        /// <returns>ID mais alto encontrado na lista.</returns>
        private int GetHighestID()
        {

            return 0;
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
                return [];
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
        public void Get(int id)
        {
            try
            {
                
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
        public void GetFilter(string? nome, int? nivel, int? tipo, int? nivelPerigo, int? raridade)
        {
            try
            {
                
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
                
            }
            catch
            {
                throw;
            }
        }

        #endregion Public Methods

    }
}
