using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture;
using AutoFixture.Dsl;

namespace Calculo.test.CustomDummie
{
    //Classe que customiza o AutoFixture.
    public static class CustomFixture
    {

        public static IPostprocessComposer<SomaInputModel> AddSomaInputModel(){
            IPostprocessComposer<SomaInputModel> fixture = new Fixture()
            .Build<SomaInputModel>()
            .With(model => model.operador1, () => {
                var op = 12;
                return op;
            })
            .With(model => model.operador2, () => {
                var op = 90;
                return op;
            });

            return fixture;
        }
    }
}