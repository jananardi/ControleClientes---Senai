namespace ControleClientess.Models
{
    public enum StatusOs
    {
        Aberta,
        EmAndamento,
        Concluida,
        Cancelada
    }

    public class ItemStatusOs
    {
        public StatusOs Valor { get; set; }
        public string Descricao { get; set; }
    }
}
