namespace f2classes
{
    internal class treino240083
    {
        public class treino
        {

            private double distancia;
            private int duracao;
            private string tipotreino = "";

            public double Getdistancia() { return distancia; }
            public void Setdistancia(double km)
            {
                if (km > 0)
                    distancia = km;
            }
            public int GetDuracao() { return duracao; }
            public void SetDuracao(int seg)
            {
                if (seg > 0)
                    duracao = seg;
            }
            public string GetTipotreino() { return tipotreino; }
            public void SetTipotreino(string t)
            {
                t = t.ToLower();
                if (t == "caminhada" || t == "corrida" || t == "misto")
                    tipotreino = t;
            }
            public double Media(double d, int durac)
            {
                return (d * 1000 / durac);
            }
            public void DistCalVal(int t, out double d, out double v)
            {
                double w = Media(this.distancia, this.duracao);

                if (this.duracao > t)
                {
                    d = this.distancia;
                    v = w;
                }
                else
                {
                    d = -1;
                    v = -1;
                }
            }
            public double Ds(string tipo)
            {
                tipo = tipo.ToLower();

                if (this.tipotreino == tipo)
                {
                    return Media(this.distancia, this.duracao);
                }
                else
                {
                    return -1.0;
                }
            }
            public treino()
            {
                this.distancia = 10.0;
                this.duracao = 3600;
                this.tipotreino = "misto";
            }
            public treino(double d, int dur, string tipo)
            {
                Setdistancia(d);
                SetDuracao(dur);
                SetTipotreino(tipo);
            }
            public string InfoTreino()
            {
                double horas = this.duracao / 3600.0;
                return this.tipotreino + ": " + this.distancia + " (" + horas + " horas)";
            }
            public int ComparaVelocidade(treino outro)
            {
                double v1 = Media(this.distancia, this.duracao);
                double v2 = Media(outro.distancia, outro.duracao);

               
                if (v1 > 8.33 || v2 > 8.33)
                    return 0;

                if (v1 > v2)
                    return 1;
                else if (v1 < v2)
                    return -1;
                else
                    return 2;
            }
        }
    }
}




