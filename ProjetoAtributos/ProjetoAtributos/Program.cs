using ProjetoAtributos.Entity;
using ProjetoAtributos.Validation;

//OK
//var testeStringRequerida = new Carro(2000, "SupraA90", "AB0003", ProjetoAtributos.Enum.TipoMotor.JZ);
//AtributoValidator.Validate(testeStringRequerida);

var testeStringRequerida = new Carro(2000, string.Empty, "AB0003", ProjetoAtributos.Enum.TipoMotor.JZ);
AtributoValidator.Validate(testeStringRequerida);