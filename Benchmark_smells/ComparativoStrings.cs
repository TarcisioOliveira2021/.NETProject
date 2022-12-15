using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Benchmark_smells
{
    public class ComparativoStrings
    {
         public string nome1 = "Teste01";
        public string nome2 = "Teste02";

        [Benchmark]
        public bool IgualdadeNomesToLower(){
            return nome1.ToLower() == nome2.ToLower();
        }

        [Benchmark]
        public bool IgualdadeNomesToUpper(){
            return nome1.ToUpper() == nome2.ToUpper();
        }

        [Benchmark]
        public bool CaseIgnore(){
            return string.Compare(nome1,nome2, StringComparison.OrdinalIgnoreCase) == 0;
        }
        [Benchmark]
        public bool EqualsCaseIgnore(){
            return nome1.Equals(nome2, StringComparison.OrdinalIgnoreCase);
        }
    }
}