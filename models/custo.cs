using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.models
{
    public class custo
    {
        public lugares lugarSelecionado {  get; set; }
        public int QuantidadedePessoas { get; set; }

        public DateTime DatadeInicio { get; set; }
        public DateTime datadeTermino { get; set; }

        public int duracao
        {
            get => datadeTermino.Subtract(DatadeInicio).Days;
        }

        public double Valortotal
        {
            get
            {
                double Valor_participantes = QuantidadedePessoas * lugarSelecionado.Valorporpessoa;

                return Valor_participantes;
            }
        }
    }
}
