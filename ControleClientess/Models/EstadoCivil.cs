namespace ControleClientess
{
    public enum EstadoCivil
    {
        Solteiro,
        Casado,
        Separado,
        Divorciado,
        Viuvo,
        UniaoEstavel
    }

    public class ItemEstado
    {
        public EstadoCivil Valor { get; set; }
        public string Descricao { get; set; }
    }
}
