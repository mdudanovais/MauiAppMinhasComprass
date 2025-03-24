using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Descricao
        {
            get => _descricao;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Por favor, volte e preencha a descrição");
                }

                _descricao = value;
            }
        }

        private double _quantidade;
        public double Quantidade
        {
            get => _quantidade;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Por favor, retorne e preencha a quantidade corretamente");
                }
                _quantidade = value;
            }
        }

        private double _preco;
        public double Preco
        {
            get => _preco;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Por favor, preencha com um valor maior que 0");
                }
                _preco = value;
            }
        }

        public double Total => Quantidade * Preco;
    }
}