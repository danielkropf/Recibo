using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibos
{
    class Class1
    {
        public List<string> alunos = new List<string>();
        public List<string> descricoes = new List<string>();
        public int numAlunos;
        public int numDescricoes;

        void oi()
        {
            alunos.Add("daniel");
            alunos.Add("kropf");
        }

        public void addAluno()
        {
            alunos.Add(Form1.nomes.Text);
            numAlunos = alunos.Count;
        }
        public void removeAluno()
        {
            alunos.Remove(Form1.nomes.Text);
            numAlunos = alunos.Count;
        }

        public void addDescricao()
        {
            descricoes.Add(Form1.nomes.Text);
            numDescricoes = descricoes.Count;
        }
        public void removeDescricao()
        {
            descricoes.Remove(Form1.nomes.Text);
            numDescricoes = descricoes.Count;
        }

    }
}
