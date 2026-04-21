namespace f2classes
{
    
        public class Treino240083
        {
            private double distanciaKm;
            private int duracaoSegundos;
            private string tipoTreino = "";

            public double GetDistancia() { return distanciaKm; }

            public void SetDistancia(double novaDistancia)
            {
                if (novaDistancia > 0)
                    distanciaKm = novaDistancia;
            }

            public int GetDuracao() { return duracaoSegundos; }

            public void SetDuracao(int novaDuracao)
            {
                if (novaDuracao > 0)
                    duracaoSegundos = novaDuracao;
            }

            public string GetTipoTreino() { return tipoTreino; }

            public void SetTipoTreino(string novoTipo)
            {
                novoTipo = novoTipo.ToLower();

                if (novoTipo == "caminhada" || novoTipo == "corrida" || novoTipo == "misto")
                    tipoTreino = novoTipo;
            }

            public double CalcVelMedia()
            {
                return (distanciaKm * 1000) / duracaoSegundos;
            }

            public void ObterDistEVeloc(int duracaoMinima, out double distanciaResult, out double velocResult)
            {
                double velocidadeMedia = CalcVelMedia();

                if (this.duracaoSegundos > duracaoMinima)
                {
                    distanciaResult = this.distanciaKm;
                    velocResult = velocidadeMedia;
                }
                else
                {
                    distanciaResult = -1;
                    velocResult = -1;
                }
            }

            public double ObterVelocidadePorTipo(string tipoProcurado)
            {
                tipoProcurado = tipoProcurado.ToLower();

                if (this.tipoTreino == tipoProcurado)
                {
                    return CalcVelMedia();
                }
                else
                {
                    return -1.0;
                }
            }

            public Treino240083()
            {
                this.distanciaKm = 10.0;
                this.duracaoSegundos = 3600;
                this.tipoTreino = "Misto";
            }

            public Treino240083(double distanciaInicial, int duracaoInicial, string tipoInicial)
            {
                SetDistancia(distanciaInicial);
                SetDuracao(duracaoInicial);
                SetTipoTreino(tipoInicial);
            }

            public string InfoTreino()
            {
                double duracaoHoras = this.duracaoSegundos / 3600.0;
                return tipoTreino + ": " + distanciaKm + " (" + duracaoHoras + " horas)";
            }

            public int ComparaVelocidade(Treino240083 outroTreino)
            {
                double velocidadeAtual = CalcVelMedia();
                double velocidadeOutro = CalcVelMedia();

                if (velocidadeAtual > 8.33 || velocidadeOutro > 8.33)
                    return 0;

                if (velocidadeAtual < velocidadeOutro)
                    return 1;
                else
                    return -1;
            }
        }
    
}