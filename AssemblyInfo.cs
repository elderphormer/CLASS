using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nums240083
{
    public class Numeros
    {
        private Num33Zero3[] m_numeros;
        private int m_qtdNums;

        public Numeros(int capacidade)
        {
            m_numeros = new Num33Zero3[capacidade];
            m_qtdNums = 0;
        }

        public int qtdNums
        {
            get { return m_qtdNums; }
            set { m_qtdNums = value; }
    }
}

