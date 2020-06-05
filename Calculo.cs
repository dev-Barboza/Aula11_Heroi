using System;

class Calculo
{
    public string Calcular()
    {
        return "nao houve nenhum calculo a ser aplicado";
    }

    public string Calcular(int vida)
    {
        return "a vida do jogador está com " + vida;
    }

     public string Calcular (int vida, int armadura)
    {
        return "a vida do jogador com a armadura Mark I é : " + armadura;
    }
    
    

    

    public string Calcular(string nome , string sobrenome)
    {
        return "nome do completo do jogador é " + nome + sobrenome;
    }

    public string Calcular(string heroi)
    {
        return "Conhecido como : " + heroi;
    }

   
}