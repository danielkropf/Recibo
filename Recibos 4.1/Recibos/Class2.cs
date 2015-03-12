using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Recibos
{
    class Class2
    {
        Class1 classe1 = new Class1();

        public void saveAlunos()
        {
            StreamWriter alunos;
            alunos = new StreamWriter("alunos.txt");
            for (int i = 0; i < classe1.numAlunos; i++)
            {
                alunos.WriteLine(classe1.alunos[i]);
            }
            alunos.Close();
        }
        public void loadAlunos()
        {
            StreamReader alunos2;
            alunos2 = new StreamReader("alunos.txt");
            classe1.alunos.Clear();
            for (int i = 0; i < classe1.numAlunos; i++)
            {
                Form1.nomes.AutoCompleteCustomSource.Add(alunos2.ReadLine());
                classe1.alunos.Add(alunos2.ReadLine());
            }
            alunos2.Close();
        }
        public void newArquivoAlunos()
        {
            File.Delete("alunos.txt");
        }

    }
}
