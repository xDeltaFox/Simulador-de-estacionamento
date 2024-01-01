namespace SimulandoEstacionamento;

public class Cliente
{
    private string _nome, _veiculo, _cidade;
    private int _idade, _id;

    public Cliente(string Nome, int Idade, string Cidade, string Veiculo)
    {
        _nome = Nome;
        _idade = Idade;
        _cidade = Cidade;
        _veiculo = Veiculo;

        string idtemp = new Random().Next(999999).ToString();
        string id2 = "";
        if (idtemp.Length < 6)
            for(int r = 0; r <= (idtemp.Length - 6); r++)
            {
                id2 += "0";
            }
        
        id2 += idtemp;
        _id = Convert.ToInt32(id2);
    }
}