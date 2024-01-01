namespace SimulandoEstacionamento;

public class Estacionamento
{
    private Tempo _tempo;

    private Dictionary<int, string> _veiculos = new Dictionary<int, string>();
    private double _caixa = 0;
    public Dictionary<int, TimeSpan> _vagasocupadas = new Dictionary<int, TimeSpan>();

    public Estacionamento(Tempo tempo)
    {
        _tempo = tempo;
    }

    public void CobrarVeiculo(int vaga)
    {
        double valor = (_tempo.TempoReal - _vagasocupadas[vaga]).Milliseconds * 5.00d;
        Console.WriteLine("Foi cobrado um valor de {0} pelo tempo da vaga", valor);
        _caixa += valor;
        Console.WriteLine("Seu caixa é de: {0}", _caixa);
        Console.WriteLine("---------------------------------");
    }

    public void AdcionarVeiculo(string nome)
    {
        int vaga = new Random().Next(1000);
        bool cont = _vagasocupadas.Keys.Contains(vaga);
        while(cont)
        {
            vaga = new Random().Next(1000);
            cont = _vagasocupadas.Keys.Contains(vaga);
        }

        _veiculos.Add(vaga, nome);
        _vagasocupadas.Add(vaga, _tempo.TempoReal);
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Um veiculo chegou e estacionou na vaga: {0}", vaga);
    }

    public void RemoverVeiculo(int vaga)
    {
        _veiculos.Remove(vaga);
        CobrarVeiculo(vaga);
        Console.WriteLine("Veiculo da vaga {0} esta saindo.", vaga);
    }
}