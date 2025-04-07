namespace AlmoxafiradoFront.DTO
{
    public class ProdutoDTO
    {
        public int codigo { get; set; }
        public string descricao { get; set; }

        public string unMedida { get; set; }
        public int estoqueAtual { get; set; }
        public bool ePermanente { get; set; }
        public int codigoCategoria { get; set; }
    }
}
