namespace SisNDragons.Models
{
    public class PatchClasseRecord
    {
        public ClasseRecord Classe { get; set; }

        public SubclasseRecord Subclasse { get; set; }

        public PatchClasseRecord()
        {
            Classe = new ClasseRecord();
            Subclasse = new SubclasseRecord();
        }
    }
}
