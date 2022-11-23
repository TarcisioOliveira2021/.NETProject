namespace calculos;
public class Calculadora
{
    public int Soma(int operador1, int operador2) => operador1 + operador2;
    public int Subtracao(int operador1, int operador2) => operador1 - operador2;
    public int Multiplicao(int operador1, int operador2) => operador1 * operador2;
    public int Divisao(int dividento, int divisor) => dividento / divisor;
    public (int quociente, int resto) RestoDivisao(int dividento, int divisor) => (dividento / divisor, dividento % divisor);

    public bool Maior(int op1, int op2) => op1 > op2 ? true : false;
}

